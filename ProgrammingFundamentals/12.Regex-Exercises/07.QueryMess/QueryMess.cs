using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _07.QueryMess
{
    class QueryMess
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                //string txt = Console.ReadLine();// @"foo=%20foo&value=+val&foo+=5+%20+203";
                //string xt = Regex.Unescape(txt);
                string xt = Console.ReadLine();
                   // Uri.UnescapeDataString(Console.ReadLine());
                if (xt == "END") break;
                Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
               // string pat = @"([%20\+\w]+)=([\w\:\+%20\/\.]+)[^&?]*"; //72%
                string pat=@"([^&=?]*)=([^&=]*)";
                //string pat = @"([\w\:\+%20\/\.]+)=([\w\:\+%20\/\.]+)[^&?]*";//72


                Regex ws = new Regex( @"\s+");
                
                
                //string pat = @"([\s\+\w]+)=([\s\+\w]+)[^&?]*";
                foreach (Match m in Regex.Matches(xt,pat))
                {

                    var k = ws.Replace(m.Groups[1].Value.Replace("+", " ").Replace("%20"," ").Trim()," ");
                    var v =ws.Replace(m.Groups[2].Value.Replace("+", " ").Replace("%20", " ").Trim()," ");
                   // var v = ws.Replace(m.Groups[2].Value, " ");
                    //Regex.Replace(v, @" ", @"%20");
                    if (!result.ContainsKey(k))
                        result.Add(k, new List<string> { v });
                    else
                        result[k].Add(v);
                }
                foreach (var item in result)
                {
                    Console.Write($"{item.Key}=[{String.Join(", ",item.Value)}]");
                }
                Console.WriteLine();
            }
            
        }
    }
}
