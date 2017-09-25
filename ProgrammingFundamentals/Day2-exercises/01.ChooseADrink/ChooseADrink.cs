using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ChooseADrink
{
    class ChooseADrink
    {
        static void Main(string[] args)
        {
            ///////// V 2.0
            string prof = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());
            double price = 0;
            switch (prof)
            {
                case "Athlete": price = 0.70; break;
                case "Businessman":
                case "Businesswoman": price=1.00; break;
                case "SoftUni Student":price=1.70; break;
                default:
                    price=1.20;
                    break;
            }
            

            Console.WriteLine($"The {prof} has to pay {price*qty:f2}.");

            /// V 1
            //string prof = Console.ReadLine().ToLower();
            //string drink = "";
            //switch (prof)
            //{
            //    case "athlete":drink = "Water";break;
            //    case "businessman":
            //    case "businesswoman":drink = "Coffee";break;
            //    case "softuni student":drink = "Beer";break;
            //    default:
            //        drink = "Tea";
            //        break;
            //}
            //Console.WriteLine(drink);
        }
    }
}
