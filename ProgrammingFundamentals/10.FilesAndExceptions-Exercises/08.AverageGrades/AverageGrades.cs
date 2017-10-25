using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.AverageGrades
{
    class AverageGrades
    {
        static List<Student> Students = new List<Student>();
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"..\..\tests\input.txt").ToList();
            while (true)
            {
                if (lines.Count == 0 || lines[0] == String.Empty || lines[0] == null) { End(); break; }

                int count = int.Parse(lines[0]);
                lines.RemoveAt(0);
                for (int i = 0; i < count; i++)
                {
                    Update(lines[i]);
                }
                lines.RemoveRange(0, count);
                List<string> result = new List<string>();
                foreach (var st in Students
                    .Where(s=>s.AvgGrade>=5.00)
                    .OrderByDescending(s=>s.AvgGrade)
                    .OrderBy(s=>s.Name))
                {
                    result.Add($"{st.Name} -> {st.AvgGrade:f2}");

                }
                File.AppendAllLines(@"..\..\tests\output.txt", result);
                File.AppendAllLines(@"..\..\tests\output.txt", new string[] { "END of Test" });
                Students.Clear();
            }

        }

        private static void End()
        {
            //foreach (var st in Students)
            //{
            //    Console.WriteLine($"{st.Name} -> {st.AvgGrade}");

            //}
            Process.Start(@"..\..\tests\output.txt");

        }

        private static void Update(string v)
        {
            string[] input = v.Split(' ');
            
                Students.Add(new Student(input[0], input.Skip(1).Select(double.Parse).ToList()) );
            }
    }
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AvgGrade { get;  }
        public Student(string name, List<double> grades)
        {
            this.Name = name;
            this.Grades = grades;
            this.AvgGrade = grades.Average();
        }


    }
}
