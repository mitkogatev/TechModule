using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());

            //Speed = Distance ÷ Time
            int totalSeconds = seconds + hours * 3600 + minutes * 60;
            float mps = (float)distanceInMeters / totalSeconds;
            float kmph = mps*18/5;
            float distanceInMiles = distanceInMeters / 1609f;
            float totHours = totalSeconds / 3600f;
            float mph = distanceInMiles/totHours;

            Console.WriteLine(mps);
            Console.WriteLine(kmph);
            Console.WriteLine(mph);
        }
    }
}
