using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            int picsTaken = int.Parse(Console.ReadLine());
            int filterTimePerPicSeconds= int.Parse(Console.ReadLine());
            int percentGoodPics= int.Parse(Console.ReadLine());
            int uploadTimePerPic= int.Parse(Console.ReadLine());

            double filteredPics = Math.Ceiling(picsTaken * (double)percentGoodPics / 100);
            long totalUploadTime = (long)(uploadTimePerPic * filteredPics);
            long totalFilteringTime = (long)picsTaken * filterTimePerPicSeconds;
            long totaltimeSeconds = totalFilteringTime + totalUploadTime;
            //d:HH:mm:ss
            TimeSpan time = TimeSpan.FromSeconds(totaltimeSeconds);
            string str = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(str);
            
        }
    }
}
