using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] numsArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int seqCount = 1;
            int currEqElement = 0;
            int longestSeq = 1;
            int longestEqElem = numsArr[0];
            for (int i = 0; i < numsArr.Length-1; i++)
            {
                currEqElement = numsArr[i];

                if (numsArr[i] == numsArr[i + 1])
                {
                    seqCount++;
                }
                else
                {
                    if (seqCount > longestSeq)
                    {
                        longestSeq = seqCount;
                        longestEqElem = currEqElement;
                    }
                    seqCount = 1;
                }
            }
            if (seqCount > longestSeq)
            {
                longestSeq = seqCount;
                longestEqElem = currEqElement;
            }

            for (int i = 0; i < longestSeq; i++)
            {
                Console.Write(longestEqElem+" ");
            }
            Console.WriteLine();
        }
    }
}
