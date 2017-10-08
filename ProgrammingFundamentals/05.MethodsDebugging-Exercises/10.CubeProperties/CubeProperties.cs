using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string calculateWhat = Console.ReadLine().ToLower();
            switch (calculateWhat)
            {
                case "face":calcFace(cubeSide);break;
                case "space":calcSpace(cubeSide);break;
                case "volume":calcVolume(cubeSide);break;
                case "area":calcArea(cubeSide);break;
                default:
                    break;
            }
        }

        private static void calcArea(double cubeSide)
        {
            double cubeArea = 6 * Math.Pow(cubeSide, 2);
            Console.WriteLine($"{cubeArea:f2}");
        }

        private static void calcVolume(double cubeSide)
        {
            double cubeVolume = Math.Pow(cubeSide, 3);
            Console.WriteLine($"{cubeVolume:f2}");
        }

        private static void calcSpace(double cubeSide)
        {
           double cubeSpaceDiagonal= Math.Sqrt(3 * Math.Pow(cubeSide, 2));
            Console.WriteLine($"{cubeSpaceDiagonal:f2}");
        }

        private static void calcFace(double cubeSide)
        {
            double cubeFaceDiagonal = Math.Sqrt(2 * Math.Pow(cubeSide, 2));
            Console.WriteLine($"{cubeFaceDiagonal:f2}");
        }
    }
}
