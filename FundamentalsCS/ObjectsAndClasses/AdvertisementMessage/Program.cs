using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string> { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            List<string> events = new List<string> { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            List<string> authors = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
           
            Random sentences = new Random();

            int messagesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < messagesCount; i++)
            {
                int phraseRandomIndex = sentences.Next(0, phrases.Count);
                int eventsRandomIndex = sentences.Next(0, events.Count);
                int authorsRandomIndex = sentences.Next(0, authors.Count);
                int citiesRandomIndex = sentences.Next(0, cities.Count);

                Console.WriteLine($"{phrases[phraseRandomIndex]} {events[eventsRandomIndex]} {authors[authorsRandomIndex]} – {cities[citiesRandomIndex]}.");
            }

        }
    }
}
