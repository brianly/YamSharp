using System;
using System.Collections.Generic;
using YamSharp.Model;
using YamSharp.Services;

namespace YamSharpTester
{
    class Program
    {
        static void Main(string[] args)
        {
            const string token = "4AOtIV1aGW0i3ehlAilQ";
            const string baseUrl = "https://www.yammer.com/api/v1/";

            //var s = new SearchService(baseUrl, token);
            //var r = s.Search("brian");
            //Console.WriteLine(r.Json);
            //DumpUsers(r);
            //DumpMessages(r);

            //var messages = new MessageService(baseUrl, token);
            //var m = messages.GetPrivateMessages();
            //Console.WriteLine(m.Json);

            //var messages = new MessageService(baseUrl, token);
            //var r = messages.Post("Testing 1,2,3");
            //Console.WriteLine(r.Json);


            // Messages with OG metadata
            var messages = new MessageService(baseUrl, token);

            var og = new List<KeyValuePair<string, string>>
                {
                    // required
                    new KeyValuePair<string, string>("og_url", "http://www.brianlyttle.com/2013/04/debugging-problems-with-ie-zones/?demo"),
                    //optional
                    new KeyValuePair<string, string>("og_title", "Debugging problems with IE Security Zones"),
                    new KeyValuePair<string, string>("og_image", "http://www.brianlyttle.com/images/ie-zones-dialog.png"),
                    new KeyValuePair<string, string>("og_description", "An overview how to start debugging problems with zones."),
                };

            var r = messages.Post("Messages can have open graph metadata attached as long as you specify it correctly.", og, 1791121);
            Console.WriteLine(r.Json);

            Console.ReadKey();
        }

        private static void DumpMessages(SearchResponse r)
        {
            Console.WriteLine("=================");
            Console.WriteLine("Messages");

            foreach (var message in r.Messages)
            {
                Console.WriteLine(message.ToString());
            }
            Console.WriteLine();
        }

        private static void DumpUsers(SearchResponse r)
        {
            Console.WriteLine("=================");

            Console.WriteLine("Users");
            var users = r.Users;

            foreach (var user in r.Users)
            {
                Console.WriteLine(user.ToString());
            }
            Console.WriteLine();
        }
    }
}
