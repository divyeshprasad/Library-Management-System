using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library_Management_System
{
    public class EBook : Book
    {
        public int FileSize { get; set; } // in MB

        // Constructor to initialize the EBook details
        public EBook(string title, string author, string isbn, bool available, int fileSize)
            : base(title, author, isbn, available)
        {
            FileSize = fileSize;
        }

        // Override ToString method to include file size
        public override string ToString()
        {
            return base.ToString() + $", File Size: {FileSize} MB";
        }
    }
}
