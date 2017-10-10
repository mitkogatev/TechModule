using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] numsArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var nz = numsArr.GroupBy(p=>p).OrderByDescending(p=>p.Count()).Select(p=>p.Key).ToArray();

            var max = nz[0];
            Console.WriteLine(max);
        }
    }
}
