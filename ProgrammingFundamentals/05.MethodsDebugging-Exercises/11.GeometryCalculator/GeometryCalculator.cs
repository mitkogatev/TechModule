using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            switch (figure)
            {
                case "triangle": calcTriangleArea();break;
                case "square": calcSquareArea();break;
                case "rectangle": calcRectangleArea();break;
                case "circle": calcCircleArea();break;
                default:
                    break;
            }
        }

        private static void calcCircleArea()
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.PI*radius*radius:f2}");

        }

        private static void calcRectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{width*height:f2}");


        }

        private static void calcSquareArea()
        {
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine($"{side*side:f2}");
        }

        private static void calcTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{side/2*height:f2}");

        }
    }
}
