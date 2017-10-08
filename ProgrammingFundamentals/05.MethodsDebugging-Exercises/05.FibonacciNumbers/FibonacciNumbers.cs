using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            GetFib(number);

        }

        private static void GetFib(int number)
        {
            if (number == 0 || number == 1)
            {
                Console.WriteLine("1");
                return;
            }

            int prevFib = 1;
            int currFib = 1;
            int fib = 0;
            for (int i = 2; i <=number; i++)
            {
                fib = prevFib + currFib;
                currFib = prevFib;
                prevFib = fib;

            }
            Console.WriteLine(fib);
        }
    }
}
