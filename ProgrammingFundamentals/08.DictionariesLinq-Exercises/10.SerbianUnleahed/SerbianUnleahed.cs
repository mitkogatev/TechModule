using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.SerbianUnleahed
{
    class SerbianUnleahed
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> venues = new Dictionary<string, Dictionary<string, int>>();
            while (line != "End")
            {
                string[] splitted = Regex.Split(line, @"\s@|\s(?=\d)");
                //0=singer;1=venue;2=tPrice;3=tCount
                if (splitted.Length == 4)
                {
                    string venue = splitted[1];
                    string singer = splitted[0];
                    //int tPrice = int.Parse(splitted[2]);
                    //int tCount = int.Parse(splitted[3]);
                    int money = int.Parse(splitted[2]) * int.Parse(splitted[3]);
                    if (!venues.ContainsKey(venue))
                        venues.Add(venue, new Dictionary<string, int> { { singer, money } });
                    else
                    {
                        if (venues[venue].ContainsKey(singer))
                            venues[venue][singer] += money;
                        else
                            venues[venue].Add(singer, money);
                    }
                }
                line = Console.ReadLine();
            }
            /////////////////
            foreach (var venue in venues)
            {
                Console.WriteLine(venue.Key);
                foreach (var singer in venue.Value.OrderByDescending(m=>m.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }

        }
    }
}
