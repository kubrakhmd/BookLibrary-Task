using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers2
{
    internal class Book
    {
        private string _name;
        private string _author;
        private bool _isAvailable;

        // Constructor with parameters for all fields
        public Book(string name, string author, bool isAvailable)
        {
            _name = name;
            _author = author;
            _isAvailable = isAvailable; // Correctly initialize _isAvailable
        }

        // Overloaded constructor for default availability
        public Book(string name, string author) : this(name, author, true) { }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public bool IsAvailable
        {
            get { return _isAvailable; }
            set { _isAvailable = value; }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {_name}, Author: {_author}, Available: {_isAvailable}");
        }

        // Additional methods for borrowing and returning could be added here
        public void Borrow()
        {
            if (_isAvailable)
            {
                _isAvailable = false;
                Console.WriteLine($"{_name} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"{_name} is not available for borrowing.");
            }
        }

        public void Return()
        {
            _isAvailable = true;
            Console.WriteLine($"{_name} has been returned.");
        }
    }


}
