using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            ulong pidNumber = ulong.Parse(Console.ReadLine());
            uint employeeNumber = uint.Parse(Console.ReadLine());
            Console.WriteLine("First name: "+firstName);
            Console.WriteLine("Last name: "+lastName);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Gender: "+gender);
            Console.WriteLine("Personal ID: "+pidNumber);
            Console.WriteLine("Unique Employee number: "+employeeNumber);
        }
    }
}
