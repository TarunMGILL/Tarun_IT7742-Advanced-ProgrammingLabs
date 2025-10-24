using System;

namespace Lab2_AdvancedProgramming
{
    class LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public LibraryItem(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Title: " + Title + ", Author: " + Author + ", Year: " + Year);
        }
    }
}
