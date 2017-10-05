using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";

            object concat = str1 + " " + str2;
            string output = (string)concat;
            Console.WriteLine(output);
        }
    }
}
