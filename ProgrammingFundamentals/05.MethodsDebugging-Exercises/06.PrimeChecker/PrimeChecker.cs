using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            IsPrime(number);
        }

        private static void IsPrime(long number)
        {
            bool prime = true;
            if (number < 2) { prime = false; }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0) { prime = false; }
                }
            }
            Console.WriteLine(prime);
        }
    }
}
