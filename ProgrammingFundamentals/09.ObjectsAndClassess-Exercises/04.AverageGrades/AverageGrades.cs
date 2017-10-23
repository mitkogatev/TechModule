using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageGrades
{
    class AverageGrades
    {
        static void Main(string[] args)
        {
            int numStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int currStudentInput = 0; currStudentInput < numStudents; currStudentInput++)
            {
                string[] lineArgs = Console.ReadLine().Split(' ');
                string name = lineArgs[0];
                List<double> grades = lineArgs.Where((g,i)=>i>0).Select(double.Parse).ToList();
                students.Add(new Student(name, grades));
            }
            foreach (var student in students.Where(st=>st.AvgGrade>=5.00).OrderByDescending(s => s.AvgGrade).OrderBy(s=>s.Name))
            {
                Console.WriteLine($"{student.Name} -> {student.AvgGrade:F2}");
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AvgGrade { get; }
        public Student(string name,List<double> grades)
        {
            this.Name = name;
            this.Grades = grades;
            this.AvgGrade = grades.Average();
        }
    }
}
