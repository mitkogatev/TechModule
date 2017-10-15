using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                 Console.ReadLine()
                 .Split(' ')
                 .Select(
                     x => int.Parse(
                     String.Join("", x.Reverse())
                     )
                     )
                     .Sum()
                );
        }
    }
}
