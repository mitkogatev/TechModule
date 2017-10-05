using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int numOfPpl = int.Parse(Console.ReadLine());
            int elevCapacity = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Ceiling((double)numOfPpl/elevCapacity));
        }
    }
}
