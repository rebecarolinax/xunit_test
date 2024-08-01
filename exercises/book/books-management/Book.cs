using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_management
{
    public class Book
    {
        public string? Name { get; set; }

        public Book(string name)
        {
            Name = name;
        }
    }
}
