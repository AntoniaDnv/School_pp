using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertismentMessage
{
    public class Message
    {
        private string phrase;
        private string events;
        private string authors;
        private string cities;

        public string[] Phrases {get;} = {
             "Excellent product.", "Such a great product.", "I always use that product.",
             "Best product of its category.", "Exceptional product.", "I can’t live without this product."
        };

        public string[] Events { get; } = {
            "Now I feel good.", "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.", "I feel great!"
        };
        public string[] Authors { get; } = {
           "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
        };
        public string[] Cities { get; } = {
            "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
        };
        private Random rndm;

        public Message()
        {
            rndm = new Random();

        }
        public void MessageCompilation()
        {
            phrase = Phrases[rndm.Next(Phrases.Length)];
            events = Events[rndm.Next(Events.Length)];
            authors = Authors[rndm.Next(Authors.Length)];
            cities = Phrases[rndm.Next(Cities.Length)];
           
            Console.WriteLine($"{phrase} {events} {authors} - {cities}");
        }
    }
}
