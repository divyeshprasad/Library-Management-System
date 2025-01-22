using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class BookFactory
    {
        public static Book CreateBook(string title, string author, string isbn, bool available, int? fileSize = null)
        {
            if (fileSize.HasValue)
            {
                return new EBook(title, author, isbn, available, fileSize.Value);
            }
            return new Book(title, author, isbn, available);
        }
    }
}
