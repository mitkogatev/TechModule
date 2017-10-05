using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PrintPartOfASCIITable
{
    class PrintPartOfASCIITable
    {
        static void Main(string[] args)
        {
            int startChar = int.Parse(Console.ReadLine());
            int endChar = int.Parse(Console.ReadLine());

            for (char i = (char)startChar; i <= (char)endChar; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

        }
    }
}
