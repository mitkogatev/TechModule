using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BigInteger[] input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger target = input[1];
            BigInteger toBase = input[0];
            StringBuilder str = new StringBuilder();
            while (target != 0)
            {
                str.Insert(0,target % toBase);
                target = target / toBase;
            }
            Console.WriteLine(str);
        }
    }
}
