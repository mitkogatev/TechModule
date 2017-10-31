using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.UseYourChainsBuddy
{
    class UseYourChainsBuddy
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            string txt = Console.ReadLine();
                //@"<html><head><title></title></head><body><h1>Intro</h1><ul><li>Item01</li><li>Item02</li><li>Item03</li></ul><p>jura qevivat va jrg fyvccrel fabjl</p><div><button>Click me, baby!</button></div><p> pbaqvgvbaf fabj  qpunvaf ner nofbyhgryl rffragvny sbe fnsr unaqyvat nygubhtu fabj punvaf znl ybbx </p><span>This manual is false, do not trust it! The illuminati wrote it down to trick you!</span><p>vagvzvqngvat gur onfvp vqrn vf ernyyl fvzcyr svg gurz bire lbhe gverf qevir sbejneq fybjyl naq gvtugra gurz hc va pbyq jrg</p><p> pbaqvgvbaf guvf vf rnfvre fnvq guna qbar ohg vs lbh chg ba lbhe gverf</p></body>";
            //@"<html><head><title></title></head><body><h1>hello</h1><p>znahny!@#%&&&&****</p><div><button>dsad</button></div><p>grkg^^^^%%%)))([]12</p></body></html>";
            //Console.WriteLine(txt);
            Regex ws = new Regex(@"[^a-z0-9]");
            string pat = @"<p>(.*?)<\/p>";
            
            //var fg = Regex.Matches(txt, @"<p>(.*?)<\/p>", RegexOptions.Multiline);
            foreach (Match m in Regex.Matches(txt,pat) )
            {
               // Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
                var r = ws.Replace(m.Groups[1].Value," ");
               result+= Decrypt(r);
            }
            //var r = ws.Replace(Regex.Match(txt, @"<p>(.*?)<\/p>").Groups[1].Value," ");
            //    Decrypt(r);
            Console.WriteLine(result);
        }

        private static string Decrypt(string r)
        {
            Dictionary<char,char> rep= new Dictionary<char, char>();
            char j = 'n';
            for (char i = 'a'; i <='m'; i++)
            {
                rep.Add(i,j);
                j++;
            }
            j = 'a';
            for (char i = 'n'; i <= 'z'; i++)
            {
                rep.Add(i, j);
                j++;
            }
            StringBuilder tmp = new StringBuilder(r);
            for (int i = 0; i < tmp.Length; i++)
            {
                try
                {
                    tmp[i] = rep[tmp[i]];
                }
                catch { }
            }
            var decrypted = Regex.Replace(tmp.ToString(), "\\s+", " ");
           return decrypted;
        }
    }
}
