using Newtonsoft.Json.Linq;
using YamSharp.Model;

namespace YamSharp.Services
{
    public class SearchService
    {
        private readonly Client _client;

        public SearchService(string baseUrl, string token)
        {
            _client = new Client(baseUrl, token);
        }

        public SearchResponse Search(string term)
        {
            var path = FormatUrl(term);
            var jsonObj = _client.Get<JObject>(path);
            var result = new SearchResponse(jsonObj);

            return result;
        }

        private string FormatUrl(string term)
        {
            return string.Format("search.json?search={0}", term);
        }
    }
}
