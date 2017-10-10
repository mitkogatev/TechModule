using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] words1 = Console.ReadLine().Split(' ');
            string[] words2 = Console.ReadLine().Split(' ');

            string[] shorterArr;
            string[] longerArr;
            if (words1.Length > words2.Length)
            {
                shorterArr = words2;
                longerArr = words1;
            }
            else
            {
                shorterArr = words1;
                longerArr = words2;
            }
            int equalElementsL = 0;
            for (int i = 0; i < shorterArr.Length; i++)
            {
                if (shorterArr[i] == longerArr[i])
                {
                    equalElementsL++;
                }
            }

            int equalElementsR = 0;
            int shorterArrIndex = shorterArr.Length-1;
            for (int i = longerArr.Length-1; shorterArrIndex >= 0; i--)
            {
                if (longerArr[i] == shorterArr[shorterArrIndex])
                {
                    equalElementsR++;
                }
                shorterArrIndex--;
            }
            Console.WriteLine("{0}",equalElementsL>=equalElementsR?equalElementsL:equalElementsR);
        }
    }
}
