using Logic.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Reflection;

namespace Logic
{
    public class QuoteService
    {
        private static List<Quote> quotes;

        public  Quote GetQuote()
        {
            if (quotes == null)
            {
                var jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "quotes.json");
                var json = File.ReadAllText(jsonPath);
                quotes = JsonConvert.DeserializeObject<List<Quote>>(json);
            }

            var currentDate = DateTime.Now.Date;
            var totalQuotes = quotes.Count;
           
            var index = currentDate.DayOfYear % totalQuotes;
            return quotes[index];
        }
    }
}