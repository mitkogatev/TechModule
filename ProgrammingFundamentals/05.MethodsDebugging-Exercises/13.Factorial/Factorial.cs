using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _13.Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(calcFactorial(num));
        }

        private static BigInteger calcFactorial(int num)
        {
            if (num <= 1)
                return 1;
            return num * calcFactorial(num - 1);
        }
    }
}
