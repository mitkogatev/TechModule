using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;

            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs((int)(n1/eps)) == Math.Abs((int)(n2/eps)));
        }
    }
}
