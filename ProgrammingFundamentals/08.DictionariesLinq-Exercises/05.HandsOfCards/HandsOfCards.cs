using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.HandsOfCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>> { };
            while (line != "JOKER")
            {
                var nameCards = Regex.Split(line, ":\\s+|,\\s+");
                try
                {
                    players[nameCards[0]].AddRange(nameCards.Where((x, y) => y > 0).ToList());
                }
                catch
                {
                    players[nameCards[0]] = nameCards.Where((x, y) => y > 0).ToList();
                }
                line = Console.ReadLine();
            }
            PrintResults(players);
        }

        private static void PrintResults(Dictionary<string, List<string>> players)
        {
            foreach (var entry in players)
            {
                Console.WriteLine("{0}: {1}",entry.Key,Calc(entry.Value));
            }
        }

        private static int Calc(List<string> value)
        {
            var tmp = value.Distinct().ToArray();
            Dictionary<string, int> map = new Dictionary<string, int>
            {
            { "2",2},
            { "3",3},
            { "4",4},
            { "5",5},
            { "6",6},
            { "7",7},
            { "8",8},
            { "9",9},
            { "10",10},
            { "J",11},
            { "Q",12},
            { "K",13},
            { "A",14},
            { "S",4},
            { "H",3},
            { "D",2},
            { "C",1},
            };
            int sum = 0;
            for (int i = 0; i < tmp.Length; i++)
            {
                string right = tmp[i].Last().ToString();
                string left = tmp[i].Remove(tmp[i].Length-1);
                //Console.WriteLine($"{left} --> {right}");
                sum += map[left] * map[right];
                //Console.WriteLine($"sum={sum}");
            }
            return sum;
        }
    }
}
