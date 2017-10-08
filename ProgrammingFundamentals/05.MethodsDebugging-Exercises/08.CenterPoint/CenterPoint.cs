using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CenterPoint
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestCoords(x1, y1, x2, y2);

        }

        private static void PrintClosestCoords(double x1, double y1, double x2, double y2)
        {
            //if (
            //     (Math.Max(x1, y1) - Math.Min(x1, y1)) >=
            //     (Math.Max(x2, y2) - Math.Min(x2, y2))
            //     )
            //{
            //    Console.WriteLine($"({x1}, {y1})");
            //}
            //else
            //{
            //    Console.WriteLine($"({x2}, {y2})");
            //}
            double d1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double d2 = Math.Sqrt(x2 * x2 + y2 * y2);
            if (d1 <= d2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
