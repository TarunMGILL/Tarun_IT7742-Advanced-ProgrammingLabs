using System;

namespace Lab2_AdvancedProgramming
{
    class Manager : Employee
    {
        private int teamSize;

        public Manager(string name, int age, string id, string dept, int size) : base(name, age, id, dept)
        {
            teamSize = size;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Team Size: " + teamSize);
        }
    }
}
