using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanyeandRon
{
    internal class QuotesGenerator
    {
        public static void kanyeQuote()
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest/";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            Console.WriteLine($"------------------");
            Console.WriteLine($"Kanye: '{kanyeQuote}'");
            Console.WriteLine($"------------------");
        }

        public static void RonQuote()
        {
            var client = new HttpClient();
            var ronsURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronsResponse = client.GetStringAsync(ronsURL).Result;
            var ronQuote = JArray.Parse(ronsResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            Console.WriteLine($"------------------");
            Console.WriteLine($"Ron: '{RonQuote}'");
            Console.WriteLine($"------------------");
        }
    }
}
