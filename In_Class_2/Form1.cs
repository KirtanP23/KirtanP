/**********************************************
 * Title: In Class - 2
 * Kirtan Patel, Student ID: 100925226
 * Date: 18 Oct 2024
 * Description: This file encapsulates the Book object as a fully instantiable class.
 * It includes properties, constructors, methods, and static members as required.
 **********************************************
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace In_Class_2
{
    #region Book Class

    /// <summary>
    /// Represents a Book with details like Title, Author, Price, Year, etc.
    /// </summary>
    public class Book
    {
        // Static field to auto-increment BookId
        private static int autoIncrementId = 0;

        #region Properties

        /// <summary>
        /// Unique Book ID, auto-generated for each instance.
        /// </summary>
        public int BookId { get; private set; }

        /// <summary>
        /// Title of the Book.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Author of the Book.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Price of the Book.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Year of publication.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Publisher of the Book.
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// Total number of pages.
        /// </summary>
        public int Pages { get; set; }

        /// <summary>
        /// Genre of the Book.
        /// </summary>
        public string Genre { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor that initializes a book with default values.
        /// </summary>
        public Book()
        {
            BookId = ++autoIncrementId;
            Title = "Unknown";
            Author = "Unknown";
            Price = 0;
            Year = 0;
            Publisher = "Unknown";
            Pages = 0;
            Genre = "Unknown";
        }

        /// <summary>
        /// Parameterized constructor that initializes a book with specified values.
        /// </summary>
        /// <param name="title">Title of the book</param>
        /// <param name="author">Author of the book</param>
        /// <param name="price">Price of the book</param>
        /// <param name="year">Publication year</param>
        /// <param name="publisher">Publisher of the book</param>
        /// <param name="pages">Total pages</param>
        /// <param name="genre">Genre of the book</param>
        public Book(string title, string author, decimal price, int year, string publisher, int pages, string genre)
        {
            BookId = ++autoIncrementId;
            Title = title;
            Author = author;
            Price = price;
            Year = year;
            Publisher = publisher;
            Pages = pages;
            Genre = genre;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns a string with the full details of the book.
        /// </summary>
        /// <returns>A string containing book details.</returns>
        public string GetBookDetails()
        {
            return $"ID: {BookId}, Title: {Title}, Author: {Author}, Price: {Price:C}, Year: {Year}, Publisher: {Publisher}, Pages: {Pages}, Genre: {Genre}";
        }

        /// <summary>
        /// Compares two books based on their prices.
        /// </summary>
        /// <param name="book1">First book to compare</param>
        /// <param name="book2">Second book to compare</param>
        /// <returns>True if the first book is more expensive than the second, otherwise false.</returns>
        public static bool CompareBooksByPrice(Book book1, Book book2)
        {
            return book1.Price > book2.Price;
        }

        /// <summary>
        /// Returns the total number of books created.
        /// </summary>
        /// <returns>The total book count.</returns>
        public static int GetBookCount()
        {
            return autoIncrementId;
        }

        #endregion
    }

    #endregion

    #region Form1 Class

    /// <summary>
    /// Main form class for displaying book information.
    /// </summary>
    public partial class Form1 : Form
    {
        private List<Book> bookList = new List<Book>(); // List to store books

        public Form1()
        {
            // Display all books in the list
            DisplayAllBooks();

            // Show total books count
            Console.WriteLine($"Total books created: {Book.GetBookCount()}");

            InitializeComponent();
        }

        #region Private Methods

        /// <summary>
        /// Adds a new book to the list and displays its details.
        /// </summary>
        /// <param name="title">Book title</param>
        /// <param name="author">Author of the book</param>
        /// <param name="price">Price of the book</param>
        /// <param name="year">Year of publication</param>
        /// <param name="publisher">Publisher of the book</param>
        /// <param name="pages">Total number of pages</param>
        /// <param name="genre">Genre of the book</param>
        private void AddBook(string title, string author, decimal price, int year, string publisher, int pages, string genre)
        {
            Book newBook = new Book(title, author, price, year, publisher, pages, genre);
            bookList.Add(newBook);

            // Output the details of the newly added book
            Console.WriteLine(newBook.GetBookDetails());
        }
        
        /// <summary>
        /// Displays all books in the list to the console.
        /// </summary>
        private void DisplayAllBooks()
        {
            // Example usage of the Book class
            AddBook("The Subtle Art of Not Giving a Fu*k", "Mark Manson", 49, 2016, "HarperOne", 224, "Self-help");
            AddBook("2 States", "Chetan Bhagat", 9, 2015, "Westland", 249, "Fiction");
            AddBook("The Almanack of Naval Ravikanth", "Eric Jorgenson", 279, 2020, "Magrathea Publishing", 244, "Self-help");
            AddBook("The Psychology of Money", "Morgan Housel", 129, 2020, "Harriman House", 252, "Personal Development");

            Console.WriteLine("\nList of all books:");
            foreach (Book book in bookList)
            {
                Console.WriteLine(book.GetBookDetails());
            }
        }

        #endregion
    }

    #endregion
}