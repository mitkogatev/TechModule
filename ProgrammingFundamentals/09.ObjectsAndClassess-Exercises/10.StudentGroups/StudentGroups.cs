using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.StudentGroups
{
    class StudentGroups
    {
        static List<Town> towns = new List<Town>();

        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string town = String.Empty;
            while (line != "End")
            {
                string[] inputArgs = Regex.Split(line, @"\s+=>\s+|\s(?=seats)");
                if (inputArgs.Length == 3)
                {
                    town = inputArgs[0];
                    CreateTown(inputArgs);
                }

                else
                    AddStudents(line, town);
                line = Console.ReadLine();
            }
            List<Group> groupsList=CreateGroups();
            PrintGroups(groupsList);
            //Console.WriteLine(groupsList.Count);
            //Console.WriteLine("END");
        }

        private static void PrintGroups(List<Group> groupsList)
        {
            Console.WriteLine($"Created {groupsList.Count} groups in {towns.Count} towns:");
            foreach (var group in groupsList)
            {
                Console.WriteLine($"{group.Town.Name} => {String.Join(", ",group.Students.Select(s=>s.Email))}");
            }
        }

        public static List<Group> CreateGroups()
        {
            List<Group> groups = new List<Group>();
            foreach (var town in towns.OrderBy(t=>t.Name))
            {
                groups.Add(new Group(town));//create first group
                //groups.Last().Town = town;//append town
                
                int maxSeats = town.Capacity;
                int seatsCoutner = 0;
                int studentsCounter = 0;
                foreach (var student in town.Students
                    .OrderBy(s => s.Email)
                .OrderBy(s => s.Name)
                .OrderBy(s => s.RegDate)
                    )
                {
                    groups.Last().Students.Add(student);
                    seatsCoutner++;
                    studentsCounter++;
                    if (seatsCoutner == maxSeats && studentsCounter !=town.Students.Count)
                    {
                        groups.Add(new Group(town));
                        //groups.Last().Town = town;
                        seatsCoutner = 0;
                    }
                }
            }
            return groups;
        }

        private static void CreateTown(string[] inputArgs)
        {
            towns.Add(new Town(inputArgs));
        }

        private static void AddStudents(string line, string town)
        {
            //inputArgs = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            string[] studentsArgs = Regex.Split(line, @"\s*\|\s*");
            towns.Last().Students.Add(new Student(studentsArgs));
        }
    }
    class Town
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        //public List<string[]> Groups { get; set; }
        public List<Student> Students { get; set; }
        public Town(string[] input)
        {
            this.Name = input[0];
            this.Capacity = int.Parse(input[1]);
            this.Students = new List<Student>();
        }
    }
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegDate { get; set; }
        public Student(string[] input)
        {
            this.Name = input[0];
            this.Email = input[1];
            this.RegDate = DateTime.ParseExact(input[2], "d-MMM-yyyy",CultureInfo.InvariantCulture);
        }
    }
    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
        public Group(Town town)
        {
            this.Town = town;
            this.Students = new List<Student>();
        }
    }
}
