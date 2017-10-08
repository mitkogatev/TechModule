using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace _14.FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger fact = calcFactorial(num);
            byte zeroesCount=CountZeroes(fact);
            Console.WriteLine(zeroesCount);
        }

        private static byte CountZeroes(BigInteger fact)
        {
            byte zeroes = 0;
            while (true)
            {
                if (fact % 10 == 0)
                {
                    zeroes++;
                    fact /= 10;
                }
                else break;
            }
            return zeroes;
        }

        private static BigInteger calcFactorial(int num)
        {
            if (num <= 1)
                return 1;
            return num * calcFactorial(num - 1);
        }
    }
}
