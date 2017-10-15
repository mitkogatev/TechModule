using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANumber
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var result = numbers.Take(arr[0]).ToList();
            result.RemoveRange(0, arr[1]);
            if (result.Contains(arr[2]))
                Console.WriteLine("YES!");
            else
                Console.WriteLine("NO!");
        }
    }
}
