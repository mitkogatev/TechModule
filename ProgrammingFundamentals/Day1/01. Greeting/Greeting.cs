using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            //Ivan
            //24
            //1192
            //1500.353

            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var employeeId= int.Parse(Console.ReadLine());
            var salary= double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {employeeId:d8}");
            Console.WriteLine($"Salary: {salary:f2}");

//Name: Peter
//Age: 30
//Employee ID: 00113236
//Salary: 1738.11

        }
    }
}
