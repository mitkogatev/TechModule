using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            int numbersCount = 0;
            while (true)
            {
                try
                {
                    int.Parse(Console.ReadLine());
                    numbersCount++;
                }
                catch
                {

                    break;
                }
            }
            Console.WriteLine(numbersCount);
        }
    }
}
