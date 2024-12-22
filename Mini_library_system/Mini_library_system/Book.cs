using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_library_system
{
    internal class Book
    {
        //declare the attributes of the book
        public string title { get; set; }
        public string author { get; set; }
        public string ISBN { get; set; }

        //constructor to initialize the book
        public Book(string title, string author, string ISBN)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
        }
    }
}
