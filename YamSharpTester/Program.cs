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
            const string token = "KkgK7MrQnqwXvrvTVe4eA";
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


            var messages = new MessageService(baseUrl, token);

            var og = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("og_url", "http://www.brianlyttle.com/testoddsdsdsdfsdfsdf"),
                    new KeyValuePair<string, string>("og_title", "The og obj title"),
                    new KeyValuePair<string, string>("og_image", "http://www.brianlyttle.com/images/ie-zones-dialog.png"),
                    new KeyValuePair<string, string>("og_description", "This is the description"),
                };

            var r = messages.Post("Testing opengraph", og);
            Console.WriteLine(r.Json);

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
