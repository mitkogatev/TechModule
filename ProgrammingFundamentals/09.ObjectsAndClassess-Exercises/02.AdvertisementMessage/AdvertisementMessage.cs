using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main(string[] args)
        {
            int msgCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < msgCount; i++)
            {
                //print msg
                Console.WriteLine(RndMessage.GenRandom());
            }
        }
    }
    public class RndMessage
    {
         public static string GenRandom()
        {
             //Random rnd = new Random();
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = {  "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            string msg =
                phrases[MyRnd.rnd.Next(0, phrases.Length)] + " " +
                events[MyRnd.rnd.Next(0, events.Length)] + " " +
                authors[MyRnd.rnd.Next(0, authors.Length)] + " - " +
                cities[MyRnd.rnd.Next(0, cities.Length)]+".";

            return msg;
        }
    }
    public class MyRnd
    {
        public static Random rnd = new Random();
    }
}
