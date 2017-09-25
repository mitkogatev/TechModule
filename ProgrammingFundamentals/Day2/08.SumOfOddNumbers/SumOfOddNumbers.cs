using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int numsCountToPrint = int.Parse(Console.ReadLine());
            int currentOddNumber = 1;
            int sum = 0;
            for (int i = 0; i < numsCountToPrint; i++)
            {
                Console.WriteLine(currentOddNumber);
                sum += currentOddNumber;
                currentOddNumber += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
