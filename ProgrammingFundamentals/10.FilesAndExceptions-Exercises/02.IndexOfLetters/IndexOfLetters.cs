using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IndexOfLetters
{
    class IndexOfLetters
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
            List<char> letters = new List<char>();
            for (char i = 'a'; i <= 'z'; i++)
            {
                letters.Add(i);
            }
            foreach (var letter in line)
            {
                File.AppendAllLines(@"..\..\tests\output.txt", new string[] { $"{letter} -> {letters.FindIndex(l => l == letter)}" });
            }
            File.AppendAllLines(@"..\..\tests\output.txt", new string[] { "END of Test" });

        }
    }
}
