using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            int ingredientsCount = int.Parse(Console.ReadLine());
            int calories = 0;
            for (int i = 0; i < ingredientsCount; i++)
            {
                string ingedient = Console.ReadLine().ToLower();
                switch (ingedient)
                {
                    case "cheese":calories += 500;break;
                    case "tomato sauce":calories += 150;break;
                    case "salami":calories += 600;break;
                    case "pepper":calories += 50;break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
