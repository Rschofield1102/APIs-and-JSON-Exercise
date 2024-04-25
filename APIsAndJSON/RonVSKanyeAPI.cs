using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        public static void Ron()
        {   //http client
            HttpClient client = new HttpClient();
            //url endpoint
            string ronUL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            //get request
            string ronRES = client.GetStringAsync(ronUL).Result;


            JArray ronQuote = JArray.Parse(ronRES);
            Console.WriteLine($"Ron: {ronQuote[0]}");
            Console.WriteLine();
        }


        public static void Kayne()
        {
            HttpClient client1 = new HttpClient();
            string kanyeUR = "https://api.kanye.rest";
            string kanyeRES = client1.GetStringAsync(kanyeUR).Result;

            var kanyeQuote = JObject.Parse(kanyeRES);
            Console.WriteLine($"Kayne: {kanyeQuote["quote"]}");
            Console.WriteLine();
        }
    }
}
