using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriplesOfLatinLetters
{
    class TriplesOfLatinLetters
    {
        static void Main(string[] args)
        {
            int maxLetter = int.Parse(Console.ReadLine());
            for (int l1 = 97; l1 < maxLetter+97; l1++)
            {
                for (int l2 = 97; l2 < maxLetter+97; l2++)
                {
                    for (int l3 = 97; l3 < maxLetter+97; l3++)
                    {
                        Console.WriteLine($"{(char)l1}{(char)l2}{(char)l3}");
                    }
                }
                
            }
        }
    }
}
