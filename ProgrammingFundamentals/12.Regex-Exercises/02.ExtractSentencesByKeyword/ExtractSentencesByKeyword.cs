using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.ExtractSentencesByKeyword
{
    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();

            foreach (Match sentence in Regex.Matches(text, @"(?!\s)([^!?\.]*)"))//@"(?!\s)([^!?\.]*[\.!?])"))// @"(.*[\.!?])"))
            {
                if(Regex.IsMatch(sentence.ToString(),$@"\b{pattern}\b"))
                    Console.WriteLine(sentence);
            }
        }
    }
}
