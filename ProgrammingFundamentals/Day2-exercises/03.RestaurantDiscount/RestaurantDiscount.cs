using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int gSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = "";
            double price = 0;
            if (gSize <= 50)
            {
                hall = "Small Hall";
                price = 2500;
            }
            else if (gSize > 50 && gSize <= 100)
            {
                hall = "Terrace";
                price = 5000;
            }
            else if (gSize > 100 && gSize <= 120)
            {
                hall = "Great Hall";
                price = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            switch (package)
            {
                case "Normal":price = (price + 500) * 0.95;break;
                case "Gold":price = (price + 750) * 0.9;break;
                case "Platinum":price = (price + 1000) * 0.85;break;
                
            }
            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {price/gSize:f2}$");
        }
    }
}
