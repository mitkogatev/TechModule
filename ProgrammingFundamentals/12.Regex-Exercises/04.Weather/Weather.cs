using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Weather
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end") break;
                Match match = Regex.Match(line, @"([A-Z]{2})([0-5]?\d\.[\d]+)([a-zA-Z]+)\|");
                if (match.Groups[1].Value != string.Empty)
                {
                    string n = match.Groups[1].Value;
                    int idx = cities.FindIndex(c => c.Name == n);
                    if (idx==-1)
                    {
                        cities.Add(new City(match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value));
                    }
                    else
                    {
                        cities[idx].AvgTemp = double.Parse(match.Groups[2].Value);
                        cities[idx].Weather = match.Groups[3].Value;
                    }
                }
            }
            foreach (var city in cities.OrderBy(c=>c.AvgTemp))
            {
                Console.WriteLine($"{city.Name} => {city.AvgTemp:f2} => {city.Weather}");
            }
        }
    }
    class City
    {
        public string Name { get; set; }
        public double AvgTemp { get; set; }
        public string Weather { get; set; }
        public City(string name, string temp, string weather)
        {
            this.Name = name;
            this.AvgTemp = double.Parse(temp);
            this.Weather = weather;
        }

    }
}
