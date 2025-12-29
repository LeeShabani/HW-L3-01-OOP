using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_oop_library;



namespace HomeWork3_Task1
{
    public class Library
    {
        List<Bookcs> Books;

        public Library(List<Bookcs> books)
        {
            Books = books;
        }

        public void AddBook(Bookcs book)
        {
            Books.Add(book);
            Console.WriteLine("Book added");
        }

        public void BorrowBook(int isbn)
        {
            Console.WriteLine("please enter isbn");

            foreach (var book in Books)
            {
                if (book.Isbn == isbn)
                {
                    book.IsAvailable = false;
                    Console.WriteLine("the book you want was borrow to someone else");
                }
                else
                {
                    Console.WriteLine("this book not available");
                }
            }
        }

        public void ReturnBook(int isbn)
        {
            Console.WriteLine("please enter isbn");
            foreach (var book in Books)
            {
                if (book.Isbn == isbn)
                {
                    book.IsAvailable = true;
                    Console.WriteLine("Thank you");
                }
                else
                {
                    Console.WriteLine("this book not available");
                }
            }
        }
        public void DisolayBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine($"Title {book.Title} , Author {book.Author},  isbn {book.Isbn}, Available {book.IsAvailable}");
            }
        }
    }
}