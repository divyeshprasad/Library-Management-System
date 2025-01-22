using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void Addbook(Book book)
        {
            books.Add(book);
        }
        public void Removebook(string isbn)
        {
            books.RemoveAll(b => b.Isbn == isbn);
        
        }

        public Book SearchBookByTitle(string title)
        {
            foreach (Book book in new List<Book>(books))
            {
                if(book.Title.ToLower() == title.ToLower())
                {
                    return book;
                }
               
                
                
            }
            Console.WriteLine("Book Not found");
            return null;
        }

        public void ListBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
