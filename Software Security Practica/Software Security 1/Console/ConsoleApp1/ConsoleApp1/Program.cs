using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Call asynchronous network methods in a try/catch block to handle exceptions.
        try
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://www.google.com/");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseBody);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message: {0}", e.Message);
        }
    }
}
