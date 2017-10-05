using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CenturiesToNanoseconds
{
    class CenturiesToNanoseconds
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 365.2422);
            uint hours = days * 24;
            uint minutes = hours * 60;
            ulong seconds = (ulong)minutes * 60;
            ulong miliseconds = seconds * 1000;
            ulong microseconds = miliseconds * 1000;
            decimal nanoseconds = microseconds * 1000m;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} " +
                $"hours = {minutes} minutes = {seconds} " +
                $"seconds = {miliseconds} milliseconds = {microseconds} " +
                $"microseconds = {nanoseconds} nanoseconds");

        }
    }
}
