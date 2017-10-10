using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            //char[] charArray=new char[26];
            //int c= 0;
            //for (char i = 'a'; i <='z'; i++)
            //{
            //     charArray[c] = i;
            //    c++;
            //}

            char[] word = Console.ReadLine().ToArray();
            int ind = 0;
            for (int i = 0; i < word.Length; i++)
            {
              
                Console.WriteLine($"{word[i]} -> {getIndex(word[i])}");
            }
        }

        private static int getIndex(char v)
        {
            int index = -1;
            for (char i = 'a'; i <= v; i++)
            {
                index++;
            }
            return index;
        }
    }
}
