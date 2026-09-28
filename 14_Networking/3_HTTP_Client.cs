using System;
using System.Net.Http;

namespace NetworkingLearn
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using HttpClient client = new HttpClient();

            string url = "https://jsonplaceholder.typicode.com/todos/1";
            string response = await client.GetStringAsync(url);

            Console.WriteLine(response);
        }
    }
}
