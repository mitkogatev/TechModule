using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LongerLine
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double dist1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2));
            double dist2 = Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2));

            //Console.WriteLine(dist1+"<=>"+dist2);
            if (dist1 >= dist2)
            {
                PrintClosestCoords(x1, y1, x2, y2);
            }
            else
            {
                PrintClosestCoords(x3, y3, x4, y4);
            }

        }
        private static void PrintClosestCoords(double x1, double y1, double x2, double y2)
        {
            double d1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double d2 = Math.Sqrt(x2 * x2 + y2 * y2);
            if (d1 <= d2)
            {
                Console.Write($"({x1}, {y1})");
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.Write($"({x2}, {y2})");
                Console.WriteLine($"({x1}, {y1})");

            }
        }
    }
}
