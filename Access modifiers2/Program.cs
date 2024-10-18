namespace Access_modifiers2
{
    using System;

    namespace Access_modifiers2
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Create an instance of BookLibrary
                BookLibrary library = new BookLibrary { Name = "City Library" };

                var book1 = new Book("1984", "George Orwell"); // Availability defaults to true
                var book2 = new Book("Fahrenheit 451", "Ray Bradbury",true); // Available is set to false

                // Adding books to the library
                library.AddBook(new Book("Fahrenheit 451", "Ray Bradbury"));
                library.AddBook(new Book("1984", "George Orwell"));
                library.AddBook(new Book("Chess", "Stefan Zweig"));
                library.AddBook(new Book("Animal Farm", "George Orwell"));
                library.AddBook(new Book("Martin Eden", "Jack London")); // Added Martin Eden

                // Show all books
                Console.WriteLine("All books in the library:");
                library.ShowBooks();
                Console.WriteLine();

                Console.WriteLine("Borrowing a book:");
                library.BorrowBook(book1);
                Console.WriteLine();

                // Showing all books after borrowing
                Console.WriteLine("Books after borrowing:");
                library.ShowBooks();
                Console.WriteLine();

                // Returning a book
                Console.WriteLine("Returning a book:");
                library.ReturnBook(book1);
                Console.WriteLine();

                // Showing all books after returning
                Console.WriteLine("Books after returning:");
                library.ShowBooks();
                Console.WriteLine();

                // Searching for books by an author
                Console.WriteLine("Searching for books by George Orwell:");
                library.SearchByAuthor("George Orwell");
                Console.WriteLine();

                // Removing a book
                Console.WriteLine("Removing a book:");
                library.RemoveBook("Animal Farm");
                Console.WriteLine();

                // Show all books after removal
                Console.WriteLine("Books after removal:");
                library.ShowBooks();
            }
        }
    }

}
