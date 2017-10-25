using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
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
            var nums = line.Split(' ').Select(int.Parse).ToList();
            int maxCount = 0;
            int value = -1;

            foreach (var num in nums.Distinct())
            {
                int currCount = nums.Where(n => n == num).Count();
                if (currCount > maxCount)
                { maxCount = currCount; value = num; }
            }
            string r = "";
            for (int i = 0; i < maxCount; i++)
            {
                r = r+value + " ";
            }
            File.AppendAllLines(@"..\..\tests\output.txt", new string[] { r });
            File.AppendAllLines(@"..\..\tests\output.txt", new string[] { "END of Test" });
        }
    }
}
