using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            for (int i = Math.Min(firstNum,secondNum); i <= Math.Max(firstNum,secondNum); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
