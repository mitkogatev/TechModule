using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int maxNum = int.Parse(Console.ReadLine());
            int tmpNum = 0;
            int sumOfDigits = 0;
            for (int i = 1; i <= maxNum; i++)
            {
                tmpNum = i;
                sumOfDigits = 0;
                while (tmpNum > 0)
                {
                    sumOfDigits += tmpNum % 10;
                    tmpNum /= 10;
                }
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
