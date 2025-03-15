using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_oop
{
    public abstract class user
    {

        public string Name { get; set; }

        public void  DisplayBooks(library library)
        {
            library.Display();

        }
    }
}
