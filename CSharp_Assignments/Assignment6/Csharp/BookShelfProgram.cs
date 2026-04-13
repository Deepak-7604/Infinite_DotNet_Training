using System;

namespace Assignment
{
    class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        public void Display()
        {
            Console.WriteLine("Book Name: " + BookName);
            Console.WriteLine("Author Name: " + AuthorName);
            Console.WriteLine();
        }
    }

    class BookShelf
    {
        private Books[] books;

        public BookShelf(int size)
        {
            books = new Books[size];
        }

        public Books this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("Books on the bookshelf:\n");
            foreach (var book in books)
            {
                if (book != null)
                    book.Display();
            }
        }
    }

    class BookShelfProgram
    {
        static void Main()
        {
            BookShelf shelf = new BookShelf(5);

            // Assign books with full author names
            shelf[0] = new Books("Book A", "Mr. John Smith");
            shelf[1] = new Books("Book B", "Mr. David Johnson");
            shelf[2] = new Books("Book C", "Mrs. Emily Davis");
            shelf[3] = new Books("Book D", "Ms. Laura Wilson");
            shelf[4] = new Books("Book E", "Mr. Michael Brown");

            shelf.DisplayAllBooks();

            Console.WriteLine("Program executed successfully. Press any key to exit.");
            Console.ReadKey();
        }
    }
}