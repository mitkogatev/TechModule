using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder toUtf = new StringBuilder();
            foreach (var ch in input)
            {
                var dec = (int)ch;

                toUtf.Append("\\u00"+dec.ToString("X"));
            }
            Console.WriteLine(toUtf.ToString().ToLower());
        }
    }
}
