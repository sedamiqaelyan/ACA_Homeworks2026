using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Homework11;

namespace Homework11
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }

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

        private  Book[] _books;
        private int _count;
        static int TotalLibraries;

        public Library(int Size)
        {
            _books = new Book[Size];
            TotalLibraries++;
            
        }

        public void AddBook(Book book)
        {
            if ((_count < _books.Length))
            {
                _books[_count++] = book;
            }
            else
            {
                Console.WriteLine("Library is full");
            }
            
        }
        public void BorrowBook(string Title)
        {

            for (int i = 0; i < _count; i++)
            {
                if (_books[i].Title == Title)
                {

                    Console.WriteLine($"Borrowed: {Title}");
                    _books[i].IsAvailable = false;
                    return;
                }

            }
            Console.WriteLine("Not available");


        }

        public void ReturnBook(String title)
        {

            for (int i = 0; i < _count; i++)
            {
                if (_books[i].Title == title)
                {

                    Console.WriteLine($"returned: {title}");
                    _books[i].IsAvailable = true;
                    return;
                }


            }
            Console.WriteLine("Not available");

        }

        public void ListAvailable()
        {
            for (int i = 0; i < _count; i++)
            {
                if (_books[i].IsAvailable)
                {
                    Console.WriteLine($"{_books[i].Title} by {_books[i].Author}");
                }
            }

        }

    }


}

