using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EqualSums
{
    class EqualSums
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
            int[] nums = line.Split(' ').Select(int.Parse).ToArray();
            int index = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Take(i).Sum() == nums.Skip(i + 1).Sum())
                {
                    index = i;
                    break;
                }
            }
            string result = index == -1 ? "no" : index.ToString();
            File.AppendAllLines(@"..\..\tests\output.txt", new string[] {result});
            File.AppendAllLines(@"..\..\tests\output.txt", new string[] { "END of Test" });


        }
    }
}
