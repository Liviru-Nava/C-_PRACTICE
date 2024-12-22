using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_library_system
{
    class Library
    {
        //create a list of books 
        private List<Book> books = new List<Book>();

        //logic to add a new book
        public void addBook()
        {
            Console.WriteLine("Please enter the title of the book: ");
            string title = Console.ReadLine();

            Console.WriteLine("Please enter the author of the book: ");
            string author = Console.ReadLine();

            Console.WriteLine("Please enter the ISBN of the book: ");
            string ISBN = Console.ReadLine();

            Book book = new Book(title, author, ISBN);
            books.Add(book);
        }

        //display all the books
        public void displayBook()
        {
            if(books.Count == 0)
            {
                Console.WriteLine("There are no books in the library at the moment");
                return;
            }

            foreach(Book book in books)
            {
                Console.WriteLine("Title: " + book.title);
                Console.WriteLine("Author: " + book.author);
                Console.WriteLine("ISBN: " + book.ISBN);
                Console.WriteLine("-------------------------------");
            }
        }

        //search book by title
        public void searchBook()
        {
            Console.WriteLine("Please enter the title of the book you want to search: ");
            string title = Console.ReadLine();

            foreach(Book book in books)
            {
                if (book.title.Equals(title))
                {
                    Console.WriteLine($"The book you searched: \n Title: {book.title}\n Author: {book.author}\n ISBN: {book.ISBN}");
                }
                else
                {
                    Console.WriteLine("Book was not found!");
                    return;
                }
            }
        }

        //delete book by ISBN
        public void deleteBook()
        {
            Console.WriteLine("Please enter the ISBN of the book to delete: ");
            string ISBN = Console.ReadLine();

            foreach (Book book in books)
            {
                if (book.ISBN.Equals(ISBN))
                {
                    books.Remove(book);
                    Console.WriteLine("Book deleted successfully!");
                    return;
                }
            }
        }
    }
}
