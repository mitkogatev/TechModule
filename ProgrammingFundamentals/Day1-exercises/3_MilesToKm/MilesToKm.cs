using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MilesToKm
{
    class MilesToKm
    {
        static void Main(string[] args)
        {
            double inputMiles = double.Parse(Console.ReadLine());
            Console.WriteLine($"{inputMiles* 1.60934:f2}");
        }
    }
}
