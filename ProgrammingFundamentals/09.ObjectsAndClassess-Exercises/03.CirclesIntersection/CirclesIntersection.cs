using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _03.CirclesIntersection
{
    class CirclesIntersection
    {

        static void Main(string[] args)
        {
            Circle c1 = new Circle(Console.ReadLine().Split(' ').Select(double.Parse).ToArray());//new Circle(4,4,2);
            Circle c2 = new Circle(Console.ReadLine().Split(' ').Select(double.Parse).ToArray());//new Circle(8,8,1);

            double dist = CalcDistBwCenters(c1.Center,c2.Center);
            //Console.WriteLine(dist);
            if (Intersect(c1, c2))
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No");
        }

        private static bool Intersect(Circle c1, Circle c2)
        {
            if (CalcDistBwCenters(c1.Center, c2.Center) <= c1.Radius + c2.Radius)
                return true;
            else
                return false;

        }

        private static double CalcDistBwCenters(Point center1, Point center2)
        {
           double distance=Math.Sqrt(Math.Pow(center1.X-center2.X,2)+Math.Pow(center1.Y-center2.Y,2));
            return distance;
        }
    }
    class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }
        public Circle(double x,double y, double radius)
        {
            this.Center = new Point(x,y);
            this.Radius = radius;
        }
        public Circle(double[] arr)
        {
            this.Center = new Point(arr[0], arr[1]);
            this.Radius = arr[2];
        }
    }
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
