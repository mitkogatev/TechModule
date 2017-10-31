using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(AreExchangeable(input).ToString().ToLower());
        }

        private static bool AreExchangeable(string[] input)
        {

            int str1 = input[0].Select(c => c).Distinct().Count();
            int str2 = input[1].Select(c => c).Distinct().Count();
            if (str1 == str2)
                return true;
            return false;
        }
    }
}
