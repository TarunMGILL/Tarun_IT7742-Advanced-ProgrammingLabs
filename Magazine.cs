using System;

namespace Lab2_AdvancedProgramming
{
    class Magazine : LibraryItem
    {
        public int Issue { get; set; }
        public string Frequency { get; set; }

        public Magazine(string title, string author, int year, int issue, string freq)
            : base(title, author, year)
        {
            Issue = issue;
            Frequency = freq;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Issue: " + Issue + ", Frequency: " + Frequency);
        }
    }
}
