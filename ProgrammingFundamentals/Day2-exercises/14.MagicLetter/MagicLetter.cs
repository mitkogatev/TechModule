using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MagicLetter
{
    class MagicLetter
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char skip = char.Parse(Console.ReadLine());

            for (char i = start; i <= end; i++)
            {
                for (char j = start; j <= end; j++)
                {
                        for (char k = start; k <= end; k++)
                        {
                        if (i!=skip && j!=skip && k!=skip)
                    Console.Write($"{i}{j}{k} ");
                       }
                }
                
            }
            Console.WriteLine();
        }
    }

}