using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());
            int sumOfDigits = 0; int tempNumber = 0; bool isSpecial = false;
            for (int number = 1; number <= maxNumber; number++)
            {
                tempNumber = number;
                while (number > 0)
                {
                    sumOfDigits += number % 10;
                    number = number / 10;
                }
                isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{tempNumber} -> {isSpecial}");
                sumOfDigits = 0;
                number = tempNumber;
            }

        }
    }
}
