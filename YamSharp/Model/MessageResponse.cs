using Newtonsoft.Json.Linq;

namespace YamSharp.Model
{
    public class MessageResponse
    {
        private readonly JObject _json;

        public MessageResponse(JObject json)
        {
            _json = json;
        }

        public string Json {
            get { return _json.ToString(); }
        }
    }
}
