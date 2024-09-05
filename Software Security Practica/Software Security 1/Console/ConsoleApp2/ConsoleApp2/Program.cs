using System;
using System.Net.Http;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            bool continueFetching = true;
            using HttpClient client = new HttpClient();

            while (continueFetching)
            {
                Console.WriteLine("Enter the URL (or type 'quit' to exit):");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    continueFetching = false;
                }
                else
                {
                    HttpResponseMessage response = await client.GetAsync(input);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine($"Response from '{input}':");
                    Console.WriteLine(responseBody);

                    // Add an extra line for separation
                    Console.WriteLine();
                }
            }
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message: {0}", e.Message);
        }
    }
}