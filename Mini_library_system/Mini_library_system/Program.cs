using System;
using System.Numerics;

namespace Mini_library_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            int choice;

            do
            {
                Console.WriteLine("Library System:");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. Display all books");
                Console.WriteLine("3. Search for a book by title");
                Console.WriteLine("4. Delete a book by ISBN");
                Console.WriteLine("5. Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice <= 0 || choice > 5)
                {
                    Console.WriteLine("Invalid choice");
                    return;
                }

                switch (choice)
                {
                    case 1:
                        library.addBook();
                        break;
                    case 2:
                        library.displayBook();
                        break;
                    case 3:
                        library.searchBook();
                        break;
                    case 4:
                        library.deleteBook();
                        break;
                    case 5:
                        Console.WriteLine("Thank you for using Library system! Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 5);
        }
    }
}