using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace YamSharp.Model
{
    public class SearchResponse
    {
        private readonly JObject _json;

        public SearchResponse(JObject json)
        {
            _json = json;
        }

        public IEnumerable<JToken> Users
        {
            get
            {
                var users = _json.Property("users");
                return users.AsEnumerable();
            }
        }

        public IEnumerable<JToken> Messages
        {
            get
            {
                var messages = _json.Property("messages");
                return messages.AsEnumerable();
            }
        } 

        public string Json {
            get { return _json.ToString(); }
        }
    }
}