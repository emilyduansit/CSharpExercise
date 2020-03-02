using System;
using RestSharp;
using RestSharp.Authenticators;

namespace RestSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://api.twitter.com/1.1");
            client.Authenticator = new HttpBasicAuthenticator("username", "password");

            var request = new RestRequest("statuses/home_timeline.json", DataFormat.Json);

            var response = client.Get(request);

            Console.WriteLine(response.StatusCode.ToString());
        }
    }
}
