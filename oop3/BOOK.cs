using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oop3
{


    public class Book
    {// Common properties for all books
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        // Constructor for the base class
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }

    }
    public class EBook : Book
    {
        // Additional property for EBooks
        public double FileSize { get; set; } // in MB

        // Constructor for EBook
        public EBook(string title, string author, string isbn, double fileSize)
            : base(title, author, isbn)
        {
            FileSize = fileSize;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"File Size: {FileSize} MB");
        }
    }
    public class PrintedBook : Book
    {
        // Additional property 
        public int PageCount { get; set; }

        // Constructor 
        public PrintedBook(string title, string author, string isbn, int pageCount)
            : base(title, author, isbn)
        {
            PageCount = pageCount;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Page Count: {PageCount}");
        }
    }
}


