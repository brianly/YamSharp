using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using YamSharp.Model;

namespace YamSharp.Services
{
    public class MessageService
    {
        private readonly Client _client;

        public MessageService(string baseUrl, string token)
        {
            _client = new Client(baseUrl, token);
        }

        public MessageResponse GetAll()
        {
            var jsonObj = _client.Get<JObject>("messages.json");
            var result = new MessageResponse(jsonObj);

            return result;
        }

        public MessageResponse GetMyFeed()
        {
            var jsonObj = _client.Get<JObject>("messages/my_feed.json");
            var result = new MessageResponse(jsonObj);

            return result;
        }

        public MessageResponse GetTopConversations()
        {
            var jsonObj = _client.Get<JObject>("messages/algo.json");
            var result = new MessageResponse(jsonObj);

            return result;
        }

        public MessageResponse GetFollowedConversations()
        {
            var jsonObj = _client.Get<JObject>("messages/following.json");
            var result = new MessageResponse(jsonObj);

            return result;
        }

        public MessageResponse GetSentMessages()
        {
            var jsonObj = _client.Get<JObject>("messages/sent.json");
            var result = new MessageResponse(jsonObj);

            return result;
        }

        public MessageResponse GetPrivateMessages()
        {
            var jsonObj = _client.Get<JObject>("messages/private.json");
            var result = new MessageResponse(jsonObj);

            return result;
        }

        public MessageResponse GetReceivedMessages()
        {
            var jsonObj = _client.Get<JObject>("messages/received.json");
            var result = new MessageResponse(jsonObj);

            return result;
        }

        public MessageResponse Post(string message)
        {
            var postData = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("body", message)
                };

            var jsonObj = _client.Post<JObject>("messages.json", postData);
            var result = new MessageResponse(jsonObj);

            return result;
        }

        public MessageResponse Post(string message, List<KeyValuePair<string, string>> openGraphProperties)
        {
            var postData = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("body", message)
                };

            postData.AddRange(openGraphProperties);

            var jsonObj = _client.Post<JObject>("messages.json", postData);
            var result = new MessageResponse(jsonObj);

            return result;
        }
    }
}
