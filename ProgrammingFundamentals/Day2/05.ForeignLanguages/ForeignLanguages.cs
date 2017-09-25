using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ForeignLanguages
{
    class ForeignLanguages
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine().ToLower();
            switch (country)
            {
                case "usa":
                case "england": Console.WriteLine("English");break;
                case "spain":
                case "agrentina":
                case "mexico": Console.WriteLine("Spanish");break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
