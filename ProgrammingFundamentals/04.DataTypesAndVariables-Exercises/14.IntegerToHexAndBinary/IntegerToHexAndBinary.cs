using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string bin = Convert.ToString(input, 2);
            string hex = Convert.ToString(input, 16).ToUpper();
            Console.WriteLine(hex);
            Console.WriteLine(bin);

        }
    }
}
