using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nightsCount = int.Parse(Console.ReadLine());
            decimal studioPrice = 0, doublePrice = 0, suitePrice = 0;
            switch (month)
            {
                case "may":
                case "october":
                    studioPrice = 50;
                    doublePrice = 65;
                    suitePrice = 75;
                    break;
                case "june":
                case "september":
                    studioPrice = 60;
                    doublePrice = 72;
                    suitePrice = 82;
                    break;

                default:
                    studioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89;
                    break;
            }
            studioPrice *= nightsCount;
            doublePrice *= nightsCount;
            suitePrice *= nightsCount;
            if (nightsCount > 14)
            {
                if (month == "june" || month == "september")
                {
                    doublePrice *= 0.90m;
                }
                if (month == "july" || month == "august" || month == "december")
                {
                    suitePrice *= 0.85m;
                }
            }

             if (nightsCount > 7)
            {
                if (month == "may" || month == "october")
                {
                    studioPrice *= 0.95m;
                }
                if (month == "september"|| month == "october")
                {
                    studioPrice -= month == "september" ? 60 : 47.5m;
                }
            }
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");
        }
    }
}
