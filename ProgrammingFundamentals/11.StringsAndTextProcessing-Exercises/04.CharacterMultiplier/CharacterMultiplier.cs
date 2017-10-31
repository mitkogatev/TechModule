using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            //string str2 = Console.ReadLine();

            int sum = 0;
            string min = string.Empty;
            string max = string.Empty;
            if (str[0].Length <= str[1].Length)
            {
                min = str[0];
                max = str[1];
            }
            else
            {
                min = str[1];
                max = str[0];
            }
            int index = 0;
            for ( index = 0; index < min.Length; index++)
            {
                sum += (int)min[index] * (int)max[index];
            }
            for (int i = index; i < max.Length; i++)
            {
                sum += (int)max[i];
            }
            Console.WriteLine(sum);
        }
    }
}
