using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCrm.Rest.Model;

namespace WebCrm.Rest.Net
{
    public class ApiLogin : BaseObject
    {
        [JsonProperty("AccessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("RefreshToken")]
        public string RefreshToken { get; set; }

        [JsonProperty("Error")]
        public string Error { get; set; }

        [JsonProperty("ErrorDescription")]
        public string ErrorDescription { get; set; }

        [JsonProperty("IsError")]
        public bool IsError { get; set; }

        [JsonProperty("ExpiresIn")]
        public long ExpiresIn { get; set; }

        [JsonProperty("TokenType")]
        public string TokenType { get; set; }

        [JsonIgnore]
        public DateTime? LastLogin { get; set; }

        [JsonIgnore]
        public bool IsExpired
        {
            get
            {
                return DateTime.Now.Subtract(TimeSpan.FromSeconds(ExpiresIn)) >= LastLogin.Value;
            }
        }

        [JsonIgnore]
        public string AuthHeader
        {
            get
            {
                return $"Bearer {AccessToken}";
            }
        }

    }
}
