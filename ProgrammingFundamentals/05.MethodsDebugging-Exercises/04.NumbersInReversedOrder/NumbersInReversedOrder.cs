using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            PrintReversed(number);
        }

        private static void PrintReversed(decimal number)
        {
            string num = "" + number;
            var arr = num.ToCharArray();
            Array.Reverse(arr);

            Console.WriteLine(new string(arr));
        }
    }
}
