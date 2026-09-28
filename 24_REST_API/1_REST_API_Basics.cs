using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace RESTAPILearn
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using HttpClient client = new HttpClient();

            string url = "https://jsonplaceholder.typicode.com/posts/1";
            string response = await client.GetStringAsync(url);

            Console.WriteLine(response);
        }
    }
}
