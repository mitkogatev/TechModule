using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s)[a-zA-Z0-9]+([\-\._])*([a-zA-Z0-9]*)*@[a-zA-Z0-9]+([\-\.a-z])*\.[a-z]+";
            string input = Console.ReadLine();
            foreach (Match email in Regex.Matches(input,pattern,RegexOptions.Multiline))
            {
                Console.WriteLine(email);
            }
        }
    }
}
