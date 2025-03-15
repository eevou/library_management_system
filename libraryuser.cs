using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_oop
{
    public class libraryuser : user
    {
        public librarycard card { get; set; }
        public libraryuser(string name)
        {
            Name = name;
        }

        public void BorrowBook(Book book , library library)
        {
           library.borrow(book);
        }
        //public void ReturnBook(Book book)
        //{
        //    // add logic 
        //}

    }
}
