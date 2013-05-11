using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace YamSharp
{
    public class Client
    {
        private string baseUrl;
        private string accessToken;


        public Client(string apiBaseUrl, string token)
        {
            accessToken = token;
            baseUrl = apiBaseUrl;
        }

        public T Get<T>(string path, string args = "")
        {
            T inst = default(T);

            using (var httpClient = new HttpClient())
            {
                var url = new Uri(baseUrl + path);
                var requestMessage = CreateMessage(url, HttpMethod.Get, accessToken);
                var r = httpClient.SendAsync(requestMessage);

                return JsonConvert.DeserializeObject<T>(r.Result.Content.ReadAsStringAsync().Result);
            }
        }

        public T Post<T>(string path, IEnumerable<KeyValuePair<string, string>> parameters)
        {

            HttpContent content = new FormUrlEncodedContent(parameters); 


            using (var httpClient = new HttpClient())
            {
                var url = new Uri(baseUrl + path);

                var requestMessage = CreateMessage(url, HttpMethod.Post, accessToken, content);
                var r = httpClient.SendAsync(requestMessage);

                return JsonConvert.DeserializeObject<T>(r.Result.Content.ReadAsStringAsync().Result);
            }
        }

        public HttpRequestMessage CreateMessage(Uri address, HttpMethod method, string token)
        {
            var message = new HttpRequestMessage {
                RequestUri = address, 
                Method = method
            };

   

            message.Headers.Add("Authorization", string.Format("Bearer {0}", token));

            return message;
        }
        
        public HttpRequestMessage CreateMessage(Uri address, HttpMethod method, string token, HttpContent content)
        {
            var message = new HttpRequestMessage
            {
                RequestUri = address,
                Method = method,
                Content = content
            };

            message.Headers.Add("Authorization", string.Format("Bearer {0}", token));

            return message;
        }



    }
}
