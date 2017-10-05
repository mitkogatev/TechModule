using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExactSumOfRealNumbers
{
    class ExactSumOfRealNumbers
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            decimal sumOfNumbers = 0m;
            for (int i = 0; i < numbersCount; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sumOfNumbers += number;
            }
            Console.WriteLine(sumOfNumbers);
        }
    }
}
