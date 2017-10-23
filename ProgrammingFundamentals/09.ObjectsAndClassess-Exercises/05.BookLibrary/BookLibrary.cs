using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BookLibrary
{
    class BookLibrary
    {
        static void Main(string[] args)
        {
            int numBooks = int.Parse(Console.ReadLine());
            Library myLib = new Library();//("Fun",new List<Book>());
            myLib.Name = "Fun";
            myLib.Books = new List<Book>();
            //myLib.Books.Add
            for (int i = 0; i < numBooks; i++)
            {
                myLib.Books.Add(
                    new Book(Console.ReadLine().Split(' '))
                    );
            }
            foreach (var author in myLib.SumByAuthor())
            {
                Console.WriteLine($"{author.Key} -> {author.Value:F2}");
            }
        }
    }
    class Book
    {
        //title, author, publisher, release date (in dd.MM.yyyy format), ISBN-number and price
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
        public Book(string title,string author,string publisher,string releaseDate,string isbn,string price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = DateTime.ParseExact(releaseDate,"dd.MM.yyyy",null);
            this.ISBN = isbn;
            this.Price = Double.Parse(price);
        }
        public Book(string[] input)
        {
            this.Title = input[0];
            this.Author = input[1];
            this.Publisher = input[2];
            this.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", null);
            this.ISBN = input[4];
            this.Price = Double.Parse(input[5]);
        }
    
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public Dictionary<string, double> SumByAuthor()
        {
            Dictionary<string, double> authors = new Dictionary<string, double>();
            foreach (var book in Books)
            {
                if (!authors.ContainsKey(book.Author))
                    authors.Add(book.Author, book.Price);
                else
                    authors[book.Author] += book.Price;
            }
            return authors.OrderBy(a=>a.Key).OrderByDescending(a=>a.Value).ToDictionary(a=>a.Key, a=>a.Value);
        }
    }
}
