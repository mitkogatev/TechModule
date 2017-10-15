using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LongestIncreasingSubsequence
{
    class LongestIncreasingSubsequence
    {
        static void Main(string[] args)
        {
            int[] numbers =
            //new int[] { 11, 12, 13, 3, 14, 4, 15, 5, 6, 7, 8, 7, 16, 9, 8 };
            Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(" ",GetLis(numbers)));

        }

        private static int[] GetLis(int[] numbers)
        {
            int[] prevIndex = new int[numbers.Length];
            int[] length = new int[numbers.Length];
            int bestLength = 0;
            int lastIndex = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                length[i] = 1;
                prevIndex[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i] && length[j]+1 > length[i])
                    {
                        length[i] = length[j] + 1;
                        prevIndex[i] = j;
                    }
                }
                if (length[i] > bestLength)
                {
                    bestLength = length[i];
                    lastIndex = i;
                }
            }
            List<int> lis = new List<int> { };
            while (lastIndex>-1)
            {
                lis.Add(numbers[lastIndex]);
                lastIndex = prevIndex[lastIndex];
            }
            lis.Reverse();
            return lis.ToArray();
        }
    }
}
