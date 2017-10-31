using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.CameraView
{
    class CameraView
    {
        static void Main(string[] args)
        {
            WithRegex();
            
        }

        private static void WithRegex()
        {
            int[] skipTake = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            List<string> result = new List<string>();
            //string[] result = Regex.Split(input,@"(\|\<[A-Za-z]{"+skipTake[0]+"})");
            //string[] result = Regex.Split(input, @"(?<=\|\<)([A-Za-z]{9})");
            // foreach (Match match in Regex.Matches(input, @"(?<=\|\<[A-Za-z]{"+skipTake[0]+"})([a-zA-Z]{0,"+skipTake[1]+"})"))
            foreach (Match match in Regex.Matches(input, @"(?<=\|\<[\S\s]{" + skipTake[0] + "})([a-zA-Z0-9]{0," + skipTake[1] + "})"))
            {
                result.Add(match.ToString());
                // Console.WriteLine(match);
                //    var m = match.ToString().ToList();
                //    Console.WriteLine(string.Join("", m.Skip(input[0]).Take(input[1])));

            }
            Console.WriteLine(String.Join(", ", result));
        }
    }
}
