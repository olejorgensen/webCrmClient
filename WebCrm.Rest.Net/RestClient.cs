using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Xml.Serialization;

namespace WebCrm.Rest.Net
{
    public class RestClient : WebClient
    {
        public const int Max_number_of_objects_per_request = 1000;

        public RestClient()
            : this(Properties.Settings.Default.DefaultTimeoutMillis, Encoding.UTF8)
        {
        }

        public RestClient(int timeOut, Encoding encoding)
        {
            TimeOut = (timeOut > 0)
                ? timeOut
                : Properties.Settings.Default.DefaultTimeoutMillis;

            Encoding = encoding;
        }

        public int TimeOut { get; set; }

        public ApiLogin ApiLogin { get; private set; }


        /// <summary>
        /// Login to webCRM with a bearer token
        /// </summary>
        private ApiLogin GetLogin()
        {
            var restParameters = new Dictionary<string, object>
            {
                ["authCode"] = Properties.Settings.Default.ApiKey
            };
            var login = SendRequest<ApiLogin>("POST", "auth/apilogin", restParameters);
            login.LastLogin = DateTime.Now;
            Headers[HttpRequestHeader.Authorization] = login.AuthHeader;
            return login;
        }

        /// <summary>
        /// Login to nExt with username, password and the public key as XML.
        /// </summary>
        public void UpdateLogin()
        {
            if (ApiLogin == null || ApiLogin.IsExpired == true)
            {
                ApiLogin = GetLogin();
            }
        }

        private HttpWebRequest GetRequest(string uriString)
        {
            return GetRequest(new Uri(uriString));
        }

        private HttpWebRequest GetRequest(Uri uri)
        {
            if (uri.Scheme != Uri.UriSchemeHttps)
            {
                throw new InvalidOperationException(Properties.Settings.Default.UnsupportedSchemeExceptionMessage);
            }

            var request = WebRequest.Create(uri) as HttpWebRequest;
            request.Method = "GET";
            request.Accept = "application/json";
            request.Headers.Add(HttpRequestHeader.Authorization, ApiLogin.AuthHeader);
            return request;
        }

        public T GET<T>(string requestPath, object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            UpdateLogin();

            var uriString = $"{BaseUrl}/{requestPath}/{id}";
            var json = DownloadString(uriString);

            return JsonConvert.DeserializeObject<T>(json);
        }

        public IEnumerable<T> GET<T>(string requestPath)
        {
            var results = new List<T>();

            int page = 1;
            while (true)
            {
                UpdateLogin();

                var uriString = $"{BaseUrl}/{requestPath}";

                var queryParams = new Dictionary<string, object>
                {
                    { "Size", Max_number_of_objects_per_request },
                    { "Page", page }
                };

                var url = CreateApiUrl(requestPath, queryParams);
                var json = DownloadString(url);
                var list = JsonConvert.DeserializeObject<IEnumerable<T>>(json);

                if (list?.Any() == true)
                {
                    results.AddRange(list);

                    if (list.Count() < Max_number_of_objects_per_request)
                    {
                        break;
                    }

                }
                else
                {
                    break;
                }

                page++;
            }

            return results;
        }

        public IEnumerable<T> GET<T>(string requestPath, int size, int page)
        {
            UpdateLogin();

            var uriString = $"{BaseUrl}/{requestPath}";

            var queryParams = new Dictionary<string, object>
                {
                    { "Size", size },
                    { "Page", page }
                };

            var url = CreateApiUrl(requestPath, queryParams);
            var json = DownloadString(url);
            var list = JsonConvert.DeserializeObject<IEnumerable<T>>(json);

            return list;
        }

        private T GET<T>(string requestPath, Dictionary<string, object> queryParams)
        {
            UpdateLogin();

            var url = CreateApiUrl(requestPath, queryParams);
            var json = DownloadString(url);
            var obj = JsonConvert.DeserializeObject<T>(json);

            return obj;
        }

        private string BaseUrl
        {
            get
            {
                return $"{Properties.Settings.Default.BaseUrl.TrimEnd("/".ToCharArray())}";
            }
        }

        private Uri CreateApiUrl(string requestPath, Dictionary<string, object> queryParams = null)
        {
            var builder = new UriBuilder($"{BaseUrl}/{requestPath}");

            if (queryParams?.Any() == true)
            {
                var keyValues = new List<string>();
                foreach (var queryParam in queryParams)
                {
                    var keyValue = $"{queryParam.Key}=";
                    if (queryParam.Value != null)
                    {
                        keyValue += Uri.EscapeDataString(queryParam.Value.ToString());
                    }
                    keyValues.Add(keyValue);
                }
                builder.Query = string.Join("&", keyValues.ToArray());
            }

            var uriString = builder.ToString();
            var uri = new Uri(uriString);

            return uri;
        }

        /// <summary>
        /// Do a HTTP request with parameters
        /// </summary>
        private T SendRequest<T>(string method, string requestPath, Dictionary<string, object> parameters)
        {
            T retVal = default(T);

            // Create the URL
            var address = new Uri($"{BaseUrl}/{requestPath}");
            if (address.Scheme != Uri.UriSchemeHttps)
            {
                throw new InvalidOperationException(Properties.Settings.Default.UnsupportedSchemeExceptionMessage);
            }

            // Create request
            var request = WebRequest.Create(address) as HttpWebRequest;

            request.Method = "POST";
            request.Accept = "application/json";
        
            if (parameters != null && (method == "POST" || method == "PUT" || method == "DELETE"))
            {
                request.ContentType = "application/x-www-form-urlencoded";

                var query = CreateApiUrl(null, parameters)
                    .Query
                    .TrimStart("?".ToCharArray());

                var byteData = this.Encoding.GetBytes(query);

                request.ContentLength = byteData.Length;
                
                // Write data  
                using (Stream postStream = request.GetRequestStream())
                {
                    postStream.Write(byteData, 0, byteData.Length);
                }
            }

            // Get response  
            using (var response = request.GetResponse() as HttpWebResponse)
            {
                // Get the response stream  
                var reader = new StreamReader(response.GetResponseStream());
                var json = reader.ReadToEnd();
                retVal = JsonConvert.DeserializeObject<T>(json);
            }

            return retVal;
        }

        /// <summary>
        /// Deserialize an object of type T from XML
        /// </summary>
        private static T Deserialize<T>(string xml)
        {
            T reply;
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(xml)))
            {
                reply = Activator.CreateInstance<T>();
                var serializer = new XmlSerializer(reply.GetType());
                reply = (T)serializer.Deserialize(ms);
            }
            return reply;
        }

        protected override WebRequest GetWebRequest(Uri address)
        {
            var request = base.GetWebRequest(address);
            if (request is HttpWebRequest req)
            {
                req.AutomaticDecompression = DecompressionMethods.GZip /* | DecompressionMethods.Deflate */;
                req.Accept = "application/json";

                //req.AllowAutoRedirect = true;
                if (TimeOut > 0)
                    req.Timeout = TimeOut;
            }
            return request;
        }

    }
}