using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;

namespace KanyeandRon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuotesGenerator.kanyeQuote();
            QuotesGenerator.RonQuote();
        }
    }
}