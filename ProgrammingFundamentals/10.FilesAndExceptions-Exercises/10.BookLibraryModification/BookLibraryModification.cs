using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BookLibraryModification
{
    class BookLibraryModification
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"..\..\tests\input.txt").ToList();
            while (lines.Count > 0)
            {
                int booksCount = int.Parse(lines[0]);
                lines.RemoveAt(0);
                Library Lib = new Library { Name = "MyLib", Books = new List<Book>() };
                for (int i = 0; i < booksCount; i++)
                {
                    //read books
                    string[] input = lines[i].Split(' ');
                    Lib.Books.Add(new Book(input));
                }
                lines.RemoveRange(0, booksCount);
                DateTime targetDate = DateTime.ParseExact(lines[0], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                lines.RemoveAt(0);
                PrintResults(Lib, targetDate);
                //?? reset classes
            }
            End();
        }
        private static void End()
        {
            Process.Start(@"..\..\tests\output.txt");
        }
        private static void PrintResults(Library lib, DateTime targetDate)
        {
            List<string> result = new List<string>();
            foreach (var book in lib.Books
                .OrderBy(b => b.Title)
                .OrderBy(b => b.ReleaseDate)
                .Where(b => b.ReleaseDate > targetDate)
                )
            {
                result.Add($@"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
            }
            File.AppendAllLines(@"..\..\tests\output.txt", result);
            File.AppendAllLines(@"..\..\tests\output.txt", new string[] { "END of Test" });
        }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ISBN { get; set; }
        public double Price { get; set; }
        public Book(string[] input)
        {
            this.Title = input[0];
            this.Author = input[1];
            this.Publisher = input[2];
            this.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            this.ISBN = int.Parse(input[4]);
            this.Price = double.Parse(input[5]);
        }
    }
}
