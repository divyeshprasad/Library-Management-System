using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class LibraryManager 
    {
        private Library library = new Library();

        private static LibraryManager instance;
        public static LibraryManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LibraryManager();
                }
                return instance;
            }
        }

        // Add a book to the library
        public void AddBook(Book book)
        {
            library.Addbook(book);
        }

        // Remove a book by ISBN
        public void RemoveBook(string isbn)
        {
            library.Removebook(isbn);
        }

        // Search for a book by title
        public void SearchBook(string title)
        {
            var book = library.SearchBookByTitle(title);
            if (book != null)
            {
                Console.WriteLine(book);
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        // List all books
        public void ListBooks()
        {
            library.ListBooks();
        }

        public void ShowMenu()
        {
            Console.WriteLine("Library Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. Search Book");
            Console.WriteLine("4. List Books");
            Console.WriteLine("5. Exit");
        }

        // Handle user input for menu system
        public void HandleUserInput()
        {
            bool running = true;
            while (running)
            {
                ShowMenu();
                Console.Write("Please select an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddBookOption();
                        break;
                    case "2":
                        RemoveBookOption();
                        break;
                    case "3":
                        SearchBookOption();
                        break;
                    case "4":
                        ListBooksOption();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private void AddBookOption()
        {
            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Author: ");
            string author = Console.ReadLine();
            Console.Write("Enter ISBN: ");
            string isbn = Console.ReadLine();
            Console.Write("Is the book available (true/false): ");
            bool available = bool.Parse(Console.ReadLine());

            // Ask if it is an eBook
            Console.Write("Is this an eBook? (yes/no): ");
            string isEBook = Console.ReadLine();

            if (isEBook.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Enter File Size (in MB): ");
                int fileSize = int.Parse(Console.ReadLine());
                Book ebook = BookFactory.CreateBook(title, author, isbn, available, fileSize);
                AddBook(ebook);
            }
            else
            {
                Book book = BookFactory.CreateBook(title, author, isbn, available);
                AddBook(book);
            }
        }

        private void RemoveBookOption()
        {
            Console.Write("Enter ISBN of the book to remove: ");
            string isbn = Console.ReadLine();
            RemoveBook(isbn);
        }

        private void SearchBookOption()
        {
            Console.Write("Enter Book Title to Search: ");
            string title = Console.ReadLine();
            SearchBook(title);
        }

        private void ListBooksOption()
        {
            Console.WriteLine("Listing all books:");
            ListBooks();
        }

    }
}
