using System;

namespace Lab2_AdvancedProgramming
{
    class Book : LibraryItem
    {
        public string ISBN { get; set; }
        public string Genre { get; set; }

        public Book(string title, string author, int year, string isbn, string genre)
            : base(title, author, year)
        {
            ISBN = isbn;
            Genre = genre;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("ISBN: " + ISBN + ", Genre: " + Genre);
        }
    }
}
