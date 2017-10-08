using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Substring_Debug
{
    class SubstringDebug
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());
            jump++;
            const char Search = 'p';//1088 cyrillic
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;

                    int endIndex = jump+i;

                    if (endIndex > text.Length-1)
                    {
                        jump = text.Length-i;
                    }

                    string matchedString = text.Substring(i, jump);
                    Console.WriteLine(matchedString);
                    i += jump-1;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
