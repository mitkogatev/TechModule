using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            List<StringBuilder> input = Console.ReadLine()
                .Split(new char[] { ' ','\n','\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => new StringBuilder(s))
                .ToList();

            Dictionary<char, int> letters = new Dictionary<char, int>();
            int count = 1;
            for (char i = 'a'; i <= 'z'; i++)
            {
                letters.Add(i, count);
                count++;
            }
            double totalSum = 0;
            double sum = 0;
            foreach (var symbols in input)
            {
                bool isUpperFirst = false;
                bool isUpperLast = false;
                if (symbols[0] >= 65 && symbols[0] <= 90) isUpperFirst = true;
                if (symbols[symbols.Length - 1] >= 65 && symbols[symbols.Length - 1] <= 90) isUpperLast = true;

                double firstVal = letters[char.Parse(symbols[0].ToString().ToLower())];
                double lastVal = letters[char.Parse(symbols[symbols.Length - 1].ToString().ToLower())];
                symbols.Remove(0, 1);//remove first
                symbols.Remove(symbols.Length - 1, 1);//remove last

                int num = int.Parse(symbols.ToString());

                if (isUpperFirst)
                    sum += num / firstVal;
                else
                    sum += num * firstVal;
                if (isUpperLast)
                    sum -= lastVal;
                else
                    sum += lastVal;
                totalSum += sum;
                sum = 0;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
