using System;
using System.Net;
using Newtonsoft.Json;

namespace getrequest
{
    class Program
    {
        static void Main(string[] args)
        {
            String api_url = "https://jsonplaceholder.typicode.com/posts?_limit=5";
            var client = new WebClient();
            var json = client.DownloadString(api_url);
            Console.WriteLine(json);
        }
    }
}
