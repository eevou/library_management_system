using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_oop
{
    public class libriran:user
    {
        public int employeeNumber { get; set; }
       public libriran (string name)
        {
            Name = name;
        }

        public void AddBook(Book book , library library)
        {
            // Add logic
            library.Add(book);
            
        }

        public void RemoveBook(Book book, library library) 
        {
            library.Remove(book);
            // Add logic
        }
        public void UpdateBook(Book book)
        {
            // Add logic
        }
    }
}
