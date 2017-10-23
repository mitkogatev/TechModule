using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountWorkingDays
{
    class CountWorkingDays
    {
        static void Main(string[] args)
        {

            //Judge gives 85/100
            string format = "dd-MM-yyyy";
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(),format,CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(),format, CultureInfo.InvariantCulture);
            
            DateTime[] holidays = { DateTime.ParseExact("01-01-2000",format,CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03-2000",format,CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05-2000",format,CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05-2000",format,CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05-2000",format,CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09-2000",format,CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09-2000",format,CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11-2000",format,CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12-2000",format,CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12-2000",format,CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12-2000",format,CultureInfo.InvariantCulture) };
            int workingDays = 0;
            
            for (DateTime day = startDate; day <= endDate; day=day.AddDays(1))
            {
                if (day.DayOfWeek !=DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Sunday &&
                    (!holidays.Contains(DateTime.ParseExact(day.Day+"-"+day.Month+"-2000","d-M-yyyy",CultureInfo.InvariantCulture))))
                    workingDays++;
            }

            Console.WriteLine(workingDays);

        }
    }
}
