using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using dotnetexperiments;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var http = CreateHttpClient())
            {
                var result = http.GetAsync("api/kwartaal.huidig");
            }


            Console.WriteLine("dit is een console app");

            Console.WriteLine("dit is een string".ToUpperVowel());
            
            Console.Read();
        }

        private static HttpClient CreateHttpClient()
        {
            var client = new HttpClient {BaseAddress = new Uri("http://localhost:85/")};
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
    }

    

    public static class StringExtensions
    {
        private const string Vowels = "aeiou";

        public static string ToUpperVowel(this string input)
        {
            return string.Join("", input
                .ToCharArray()
                .Select(c =>
                {
                    if (Vowels.Contains(c)) return c.ToString().ToUpper();
                    return c.ToString();
                }));
        }
    }
}
