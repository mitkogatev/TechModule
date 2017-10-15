using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] cmd = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            
            while (numbers.IndexOf(cmd[0]) !=-1)
            {

                //remove left
                int ind = numbers.IndexOf(cmd[0]) + 1;
                int count = cmd[1];
                if (count > numbers.Count - ind - 1) { count = numbers.Count - ind; }
                numbers.RemoveRange(ind, count);

                //remove right+target
                count = cmd[1];
                ind = numbers.IndexOf(cmd[0]) - count;
                count++;
                if (ind < 0) { count += ind; ind = 0; }

                numbers.RemoveRange(ind,count);
            }

            Console.WriteLine(numbers.Sum());
        }

        
    }
}
