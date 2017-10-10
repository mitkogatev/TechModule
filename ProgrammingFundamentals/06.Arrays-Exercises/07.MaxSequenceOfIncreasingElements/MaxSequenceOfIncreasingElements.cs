using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] numsArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 1;
            int startIndex = 0;
            int endIndex = 0;
            int currSind = 0;
            int currEind = 0;
            int maxCount = 1;
            
            for (int i = 0; i < numsArr.Length-1; i++)
            {
                if (numsArr[i] < numsArr[i + 1])
                {
                    if (count == 1) currSind = i;
                    count++;
                    currEind = i + 1;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        startIndex = currSind;
                        endIndex = currEind;
                    }
                }
                else
                {
                    count = 1;
                    currSind = i+1;
                    currEind = i+1;
                }
            }
            //Console.WriteLine($"start={startIndex} end={endIndex}");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(numsArr[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
