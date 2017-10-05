using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FastPrimeChecker
{
    class FastPrimeChecker
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());
            for (int number = 2; number <= maxNumber; number++)
            {
                bool isPrime = true;
                for (int sqrt = 2; sqrt <= Math.Sqrt(number); sqrt++)
                {
                    if (number % sqrt == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {isPrime}");
            }

        }
    }
}
