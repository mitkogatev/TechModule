using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            long startNum = long.Parse(Console.ReadLine());
            long endNum = long.Parse(Console.ReadLine());

            GetOdds(startNum,endNum);
        }

        private static void GetOdds(long startNum, long endNum)
        {
            List<long> primes = new List<long> { };
            if (startNum < 2)
            {
                startNum = 2;
                primes.Add(2);
            }
            if (startNum % 2 == 0) startNum++;
            for (long i = startNum; i <= endNum; i+=2)
            {
                if (IsPrime(i)) primes.Add(i);
            }
            Console.WriteLine(String.Join(", ",primes));
        }
        private static bool IsPrime(long number)
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
            return prime;
        }
    }
}
