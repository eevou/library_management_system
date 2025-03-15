using LMS_oop;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("welcome to library system ");
        library library = new library();


        Console.WriteLine("Are u libriran or regular user(L/R) ");
        var userType = Console.ReadLine().ToLower()[0];


        Console.WriteLine("Enter your name: ");
        string libriranName = Console.ReadLine();



        if (userType == 'l')
        {
            libriran L1 = new libriran(libriranName);
            Console.Write($"welcome {L1.Name}");
            while (true)
            {
                Console.WriteLine("plz choose to add (A) / to remove (R) / to Display(D)");
                char choice = Console.ReadLine().ToUpper()[0];

                switch (choice)
                {
                    case 'A':

                        Console.WriteLine("Enter book details : ");

                        string bookName = Console.ReadLine();
                        string author = Console.ReadLine();
                        int year = int.Parse(Console.ReadLine());
                        Book newbook = new Book()
                        {
                            Title = bookName,  // look its , not ;
                            Author = author,
                            Year = year
                        };
                        L1.AddBook(newbook, library);
                        break;
                    case 'R':

                        Console.WriteLine("Enter book details to remove : ");

                        bookName = Console.ReadLine();
                        author = Console.ReadLine();
                        year = int.Parse(Console.ReadLine());
                        newbook = new Book()
                        {
                            Title = bookName,  // look its , not ;
                            Author = author,
                            Year = year
                        };
                        L1.RemoveBook(newbook, library);

                        break;
                    case 'D':

                        Console.WriteLine("Books in library :");
                        L1.DisplayBooks(library);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }


        }
        else if (userType == 'r')
        {

            libraryuser lu1 = new libraryuser(libriranName);

            while (true)
            {
                Console.WriteLine("plz choose to add (D) / to remove (B) / to Display(D)");
                char choice = Console.ReadLine().ToUpper()[0];

                switch (choice)
                {
                    case 'D':

                        Console.WriteLine("Books in library :");
                        lu1.DisplayBooks(library);
                        break;
                    case 'B':
                        Console.WriteLine("Enter book details to borrow : ");
                        string bookName = Console.ReadLine();
                        string author = Console.ReadLine();
                        int year = int.Parse(Console.ReadLine());
                        Book newbook = new Book()
                        {
                            Title = bookName,  // look its , not ;
                            Author = author,
                            Year = year
                        };
                        lu1.BorrowBook(newbook, library);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }


    }
}