using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"..\..\tests\input.txt");
            foreach (var line in lines)
            {
                if (line == string.Empty) return;
                DoStuff(line);
            }
        }

        private static void DoStuff(string line)
        {
            List<int> nums = line.Split(' ').Select(int.Parse).ToList();
            var mfn = nums.GroupBy(n=>n).OrderByDescending(gr=>gr.Count()).Select(g=>g.Key).First();
            File.AppendAllLines(@"..\..\tests\output.txt", new string[] { mfn.ToString() });
        }
    }
}
