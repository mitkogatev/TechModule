using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = numbers.GroupBy(n=>n).OrderByDescending(n=>n.Count()).ToList();
            for (int i = 0; i < result[0].Count(); i++)
            {
                Console.Write(result[0].Key+" ");
            }
            Console.WriteLine();
        }
    }
}
