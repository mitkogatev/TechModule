using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();
            while (line !="report")
            {
                string[] parsed = line.Split('|');
                //0=city;1=coutry;2=cityPop
                string city = parsed[0];
                string country = parsed[1];
                long pop = long.Parse(parsed[2]);
                //----------------------//
                if (countries.ContainsKey(country))
                {
                    //update
                    if (countries[country].ContainsKey(city))
                        countries[country][city] += pop;
                    else
                    countries[country][city] = pop;
                }
                else
                    countries[country] = new Dictionary<string, long> { {city,pop} };

                line = Console.ReadLine();
            }

            foreach (var country in countries.OrderByDescending(c=>c.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }


            Console.WriteLine();
        }
    }
}
