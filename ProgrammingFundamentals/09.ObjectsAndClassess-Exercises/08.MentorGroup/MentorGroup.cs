using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.MentorGroup
{
    class MentorGroup
    {
        static void Main(string[] args)
        {
            List<User> students = new List<User>();
            string input = Console.ReadLine().Trim();
            //read dates+create and upd date
            while (input !="end of dates")
            {
                string[] parsedLine = input.Split(new char[] {' ',',' },StringSplitOptions.RemoveEmptyEntries); //Regex.Split(input,@"\s|,");
                //if (parsedLine.Length > 1)//at least 1 date
                //{
                    int index = students.FindIndex(s => s.Name == parsedLine[0]);
                    if (index == -1)
                        students.Add(new User(parsedLine));
                    else
                        students[index].UpdateDates(parsedLine);
                //}
                 input = Console.ReadLine().Trim();
            }
            input = Console.ReadLine().Trim();
            //read comment+update
            while (input!="end of comments")
            {
                string[] parsedLine = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);//Regex.Split(input, @"-");
                int index = students.FindIndex(s => s.Name == parsedLine[0]);
                if (index != -1)
                {
                    students[index].UpdateComments(parsedLine);
                }
                input = Console.ReadLine().Trim();
            }
            foreach (var student in students.OrderBy(s=>s.Name.ToLower()))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                foreach (var comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Dates.OrderBy(d=>d))
                {
                    if(date!=null)
                    Console.WriteLine($"-- {date}");
                }
            }
            //Console.WriteLine();
        }
    }
    class User
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        //public List<DateTime> Dates { get; set; }
        public List<string> Dates { get; set; }
        public User(string[] input)
        {
            this.Name = input[0];
            this.Comments = new List<string>();
            this.Dates = input.Where((l, ind) => ind > 0).ToList();
                ////this.Dates=input.Where((l, ind) => ind > 0)
                ////.Select(l => DateTime.ParseExact(l, "dd/MM/yyyy", null)).ToList();
        }
        public void UpdateDates(string[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                //this.Dates.Add(DateTime.ParseExact(input[i], "dd/MM/yyyy", null));
                this.Dates.Add(input[i]);
            }
        }
        public void UpdateComments(string[] input)
        {
            //for (int i = 1; i < input.Length; i++)
            //{
            if (input.Length > 1)
                this.Comments.Add(input[1]);
            else
                this.Comments.Add(null);

            //}
        }

    }
}
