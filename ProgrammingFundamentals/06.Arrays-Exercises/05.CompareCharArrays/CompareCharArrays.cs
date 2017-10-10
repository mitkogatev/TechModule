using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] charArray1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] charArray2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            char[] longestArr;
            char[] shortestArr;
            if (charArray1.Length > charArray2.Length)
            {
                 longestArr = charArray1;
                 shortestArr = charArray2;
            }
            else
            {
                 longestArr = charArray2;
                 shortestArr = charArray1;
            }
            for (int i = 0; i < shortestArr.Length; i++)
            {
                if (longestArr[i] < shortestArr[i])
                {
                    Console.WriteLine(string.Join("",longestArr));
                    Console.WriteLine(string.Join("",shortestArr));
                    return;
                }

            }
            Console.WriteLine(string.Join("",shortestArr));
            Console.WriteLine(string.Join("",longestArr));

        }
    }
}
