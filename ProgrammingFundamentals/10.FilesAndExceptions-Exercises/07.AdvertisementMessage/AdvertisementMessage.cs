using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main(string[] args)
        {
            string[] Phrases = new string[]
                {
                    "Excellent product.",
                    "Such a great product.",
                    "I always use that product.",
                    "Best product of its category.",
                    "Exceptional product.",
                    "I can’t live without this product."
                };
            string[] Events = new string[]
                {
                    "Now I feel good.",
                    "I have succeeded with this product.",
                    "Makes miracles. I am happy of the results!",
                    "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.",
                    "I feel great!"
                };
            string[] Author = new string[]
                    {
                        "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
                    };
            string[] Cities = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };
            var lines = File.ReadAllLines(@"..\..\tests\input.txt");
            Random rnd = new Random();
            foreach (var line in lines)
            {
                if (line == String.Empty || line == null) End();
                int num = int.Parse(line);
                List<string> result = new List<string>();
                for (int i = 0; i < num; i++)
                {
                    string sentence =
                        Phrases[rnd.Next(0, Phrases.Length)] + " " +
                        Events[rnd.Next(0, Events.Length)] + " " +
                        Author[rnd.Next(0, Author.Length)] + " - " +
                        Cities[rnd.Next(0, Cities.Length)];
                    //Console.WriteLine(sentence);
                    result.Add(sentence);
                }
                //pr res
                File.AppendAllLines(@"..\..\tests\output.txt", result);
                File.AppendAllLines(@"..\..\tests\output.txt", new string[] { "END of Test" });
            }
            End();
        }

        private static void End()
        {
            Process.Start(@"..\..\tests\output.txt");
        }
    }
    // class Rnd
    //{
    //    public static Random rnd = new Random();
    //}
}
