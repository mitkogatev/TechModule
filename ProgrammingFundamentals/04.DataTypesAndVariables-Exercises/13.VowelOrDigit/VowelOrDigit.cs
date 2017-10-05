using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                int.Parse(input);
                Console.WriteLine("digit");
            }
            catch 
            {
                switch (input.ToLower())
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u": Console.WriteLine("vowel");break;
                    default:
                        Console.WriteLine("other");
                        break;
                }

            }
        }
    }
}
