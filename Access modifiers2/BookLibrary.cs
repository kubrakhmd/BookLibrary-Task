using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Access_modifiers2
{
    internal class BookLibrary
    {
        private string _name;
        public Book[] _books = new Book[0];

        public Book[] Books
        {
            get
            {
                return _books;
            }
            set
            {
                _books = value;
            }


        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public void AddBook(Book book)
        {
            Array.Resize(ref _books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }
        public void ShowBooks()
        {
            for (int i = 0; i < Books.Length; i++)
            {
                Books[i].GetInfo();
            }
        }
        public bool BorrowBook(Book book)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name != book.Name)
                {
                    book.IsAvailable = false;
                    return book.IsAvailable;

                }

            }
            return book.IsAvailable;
        }

        public bool ReturnBook(Book book)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name == book.Name)
                {
                    book.IsAvailable = true;
                    return book.IsAvailable;

                }

            }
            return book.IsAvailable;

        }

        public void RemoveBook(string name)
        {
            Book[] newArr = new Book[Books.Length - 1];


            int j = 0;
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name != name)
                {
                    newArr[j] = Books[i];
                    j++;
                }
            }

            Books = newArr;

            Console.WriteLine($"Removed book: '{name}'");
        }

        public void SearchByAuthor(string author)
        {
            if (string.IsNullOrWhiteSpace(author))
            {
                Console.WriteLine("Please provide a valid author name.");
                return;
            }

            author = author.Trim();
            bool found = false;
            foreach (var book in _books)
            {
                if (book.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    if (!found)
                    {
                        Console.WriteLine($"Books by {author}:");
                        found = true;
                    }
                    Console.WriteLine( );
                }
            }

            if (!found)
            {
                Console.WriteLine($"No books found by {author}.");
            }


        }

    }
}


