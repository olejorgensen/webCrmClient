using Newtonsoft.Json;

namespace WebCrm.Rest.Model
{
    public class BaseObject
    {
        public override string ToString()
        {
            var json = JsonConvert.SerializeObject(this, Formatting.Indented);
            return json;
        }
    }
}
