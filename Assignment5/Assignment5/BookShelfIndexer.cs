using System;

namespace Assignment5
{
    // Define the Books class
    class Books
    {
        // Properties
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        // Constructor
        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        // Method to display book details
        public void Display()
        {
            Console.WriteLine("Book Name: {0}", BookName);
            Console.WriteLine("Author Name: {0}", AuthorName);
            Console.WriteLine();
        }
    }

    // Define the BookShelf class
    class BookShelf
    {
        private Books[] books; // Array to store Books objects

        // Constructor
        public BookShelf()
        {
            books = new Books[5]; // Initialize array for 5 books
        }

        // Indexer for Books objects
        public Books this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        // Method to display all books in the BookShelf
        public void DisplayAllBooks()
        {
            Console.WriteLine("Books on the Bookshelf:\n");
            foreach (var book in books)
            {
                if (book != null)
                {
                    book.Display();
                }
            }
        }
    }

    class BookShelf_Test
    {
        static void Main()
        {
            // Create an instance of BookShelf
            BookShelf shelf = new BookShelf();

            // Assign values to the Books objects using indexer
            shelf[0] = new Books("Book A", "Mr. ABC");
            shelf[1] = new Books("Book B", "Mr. DEF");
            shelf[2] = new Books("Book C", "Mrs. GHJ");
            shelf[3] = new Books("Book D", "Ms. KLM");
            shelf[4] = new Books("Book E", "Mr. PQR");

            // Display all books on the BookShelf
            shelf.DisplayAllBooks();

            // Decorative messages
            Console.WriteLine("\n-----------Program Executed Successfully------------");
            Console.WriteLine(" -------END OF PROGRAM---------");
            Console.WriteLine(" Please press any key to exit.");
            Console.ReadKey();
        }
    }
}