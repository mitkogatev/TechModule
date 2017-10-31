using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();//@"ds3bhj y1ter/wfsdg 1nh_jgf ds2c_vbg\4htref";
            //string[] spl = Regex.Split(text, @"\s|\(|\)|\\|\/");
            List<string> res = new List<string>();
            //string pat = @"(\b[a-zA-Z][a-z0-9_]{2,24}\b)([^\/\\\(\)\s]*?)";
            //string pat=@"\b([a-zA-Z]+[a-z0-9_]*){3,25}\b([^\/\\\(\)\s]*)";
            // string pat = @"(\b[a-zA-Z][a-z0-9_]{2,24}\b)([^\/\\\(\)\s]*)";
            string pat = @"\b[a-zA-Z][a-z0-9_A-Z]{2,24}\b[^\/\\\(\)\s]*"; //working pat
            foreach (Match m in Regex.Matches(text,pat ))
            {
                //Console.WriteLine(m.Value);
                res.Add(m.Value);
            }
            int maxSum = 0;
            int[] idxs = new int[2];
            for (int i = 0; i < res.Count-1; i++)
            {
                int curSum = res[i].Length + res[i + 1].Length;
                if (curSum > maxSum)
                {
                    maxSum = curSum;
                    idxs[0] = i;
                    idxs[1] = i + 1;
                }
            }
            Console.WriteLine(res[idxs[0]] +Environment.NewLine+res[idxs[1]]);
        }
    }
}
