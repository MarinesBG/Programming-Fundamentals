using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Book_Library_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] readAllText = File.ReadAllLines("Input.txt");

            int numbersOfBooks = int.Parse(readAllText[0]);

            Library library = new Library();

            library.Books = new List<Book>();



            for (int i = 0; i < numbersOfBooks; i++)

            {

                string[] booksInfo = readAllText[i + 1].Split(' ');

                Book addBookInfo = new Book();

                addBookInfo.Title = booksInfo[0];

                addBookInfo.Autor = booksInfo[1];

                addBookInfo.Publisher = booksInfo[2];

                addBookInfo.ReleaseDate = DateTime.ParseExact(booksInfo[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                addBookInfo.Isbn = double.Parse(booksInfo[4]);

                addBookInfo.Price = double.Parse(booksInfo[5]);



                library.Books.Add(addBookInfo);

            }



            string dateTime = readAllText[readAllText.Length - 1];

            DateTime startDate = DateTime.ParseExact(dateTime, "dd.MM.yyyy", CultureInfo.InvariantCulture);



            Dictionary<string, DateTime> booksByTitle = new Dictionary<string, DateTime>();

            for (int i = 0; i < library.Books.Count; i++)

            {

                if (!booksByTitle.ContainsKey(library.Books[i].Title) && library.Books[i].ReleaseDate > startDate)

                {

                    booksByTitle.Add(library.Books[i].Title, new DateTime());

                    booksByTitle[library.Books[i].Title] = library.Books[i].ReleaseDate;

                }

            }



            foreach (var book in booksByTitle.OrderBy(x => x.Value).ThenBy(x => x.Key))

            {

                File.AppendAllText("output.txt", $"{book.Key:F2} -> {book.Value:dd.MM.yyyy}" + Environment.NewLine);

            }

        }

    }

    class Library

    {

        public string name { get; set; }

        public List<Book> Books { get; set; }

    }

    class Book

    {

        public string Title { get; set; }

        public string Autor { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public double Isbn { get; set; }

        public double Price { get; set; }



    }

}
            
