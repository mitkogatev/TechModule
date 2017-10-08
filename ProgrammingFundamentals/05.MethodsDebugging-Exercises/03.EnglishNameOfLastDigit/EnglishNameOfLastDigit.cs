using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishNameOfLastDigit
{
    class EnglishNameOfLastDigit
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string lastDigit = GetLastDigit(number);
            Console.WriteLine(lastDigit);

        }

        private static string GetLastDigit(long number)
        {
            int lastDigit = (int)(Math.Abs(number) % 10);
            string digitName = "";
            switch (lastDigit)
            {
                case 1:digitName = "one";break;
                case 2:digitName = "two";break;
                case 3:digitName = "three";break;
                case 4:digitName = "four";break;
                case 5:digitName = "five";break;
                case 6:digitName = "six";break;
                case 7:digitName = "seven";break;
                case 8:digitName = "eight";break;
                case 9:digitName = "nine";break;
                default: digitName = "zero";
                    break;
            }
            return digitName;
        }
    }
}
