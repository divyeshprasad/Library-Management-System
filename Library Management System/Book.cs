using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public string Isbn { get; set; }

        public Boolean Available { get; set; }

        public Book(string Title,string Author, string Isbn,Boolean Available)
        {
            this.Title = Title; 
            this.Author = Author;
            this.Isbn = Isbn;
            this.Available = Available;
        }

        
        public override string ToString()
        {
            return $"Title:{Title} , Author:{Author}, Isbn:{Isbn} ,Available: {Available}"; 
        }

    }
}
