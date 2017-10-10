using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] topArr = new int[numbers.Length / 2];
            int[] botArr = new int[numbers.Length / 2];
            int lrCount = topArr.Length / 2;
            //fill arr
            int lrIndex = lrCount - 1;
            for (int j = 0; j < botArr.Length; j++)
            {
                if (lrIndex < 0) lrIndex = numbers.Length - 1;
                botArr[j] = numbers[lrCount + j];
                topArr[j] = numbers[lrIndex];
                lrIndex--;
            }

            //sum and print
            for (int i = 0; i < topArr.Length; i++)
            {
                Console.Write("{0} ",topArr[i]+botArr[i]);
            }
            Console.WriteLine();
            //Console.WriteLine(String.Join(" ", botArr));
            //Console.WriteLine(String.Join(" ", topArr));
        }
    }
}
