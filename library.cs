using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_oop
{
    public class library
    {
        private Book[] books = new Book[100]; // max capacity of library    
        private int currrentBookCount = 0;
        private Book[] BWbooks = new Book[50];
        private int currrentBWBookCount = 0;


        public void Add(Book book)
        {
            if (currrentBookCount < books.Length)
            {
                books[currrentBookCount] = book;
                currrentBookCount++;
                Console.WriteLine("Book added to library");
            }
            else
            {
                Console.WriteLine("Library is full cannot add new book ");

            }
        }

        public void Remove(Book book)
        {
          int index =  Array.IndexOf(books, book);

            books[index] = null;
            currrentBookCount--;
            Console.WriteLine("Book removed from library");

        }

        public void Display()
        {
            foreach (var book in books)
            {
                if (book != null)
                {
                    Console.WriteLine($"Title: {book.Title}");
                }
            }   
        

        public void borrow(Book book)
        {
            if (currrentBWBookCount < BWbooks.Length)
            {
                BWbooks[currrentBWBookCount] = book;
                currrentBWBookCount++;
                Console.WriteLine("Book borrowed from library");
            }
            else
            {
                Console.WriteLine("You have reached max limit of borrowing books");
            }
        }
    }
}
