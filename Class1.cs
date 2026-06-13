using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Homework11
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            IsAvailable = true;
        }
    }

    public class Library
    {
        private Book[] _books;
        private int _count;

        private static int _totalLibraries = 0;
        public static int TotalLibraries => _totalLibraries;

        public Library(int capacity)
        {
            _books = new Book[capacity];
            _count = 0;
            _totalLibraries++;
        }

        public void AddBook(Book book)
        {
            if (_count >= _books.Length)
            {
                Console.WriteLine("Library is full.");
                return;
            }
            _books[_count++] = book;
        }

        public void BorrowBook(string title)
        {
            Book book = FindBook(title);

            if (book == null)
            {
                Console.WriteLine($"Book \"{title}\" not found.");
                return;
            }
            if (!book.IsAvailable)
            {
                Console.WriteLine($"\"{book.Title}\" is already borrowed.");
                return;
            }

            book.IsAvailable = false;
            Console.WriteLine($"Borrowed: {book.Title}");
        }

        public void ReturnBook(string title)
        {
            Book book = FindBook(title);

            if (book == null)
            {
                Console.WriteLine($"Book \"{title}\" not found.");
                return;
            }

            book.IsAvailable = true;
            Console.WriteLine($"Returned: {book.Title}");
        }

        public void ListAvailable()
        {
            Console.WriteLine("Available books:");
            bool any = false;
            for (int i = 0; i < _count; i++)
            {
                if (_books[i].IsAvailable)
                {
                    Console.WriteLine($"  - {_books[i].Title} by {_books[i].Author}");
                    any = true;
                }
            }
            if (!any) Console.WriteLine("  (none)");
        }

        private Book FindBook(string title)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_books[i].Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                    return _books[i];
            }
            return null;
        }
    }
}
*/