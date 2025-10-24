using System;

namespace Lab2_AdvancedProgramming
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Exercise 1 and 2");
            Employee testEmployee1 = new Employee("Tarun", 25, "E101", "Finance");
            testEmployee1.DisplayDetails();

            Console.WriteLine("\nOverloaded Constructors");
            Person person1 = new Person("Tarun");
            Employee testEmployee2 = new Employee("IV102", "IT Sales");
            person1.DisplayDetails();
            testEmployee2.DisplayDetails();

            Console.WriteLine("\nGetter Setter Demo");
            testEmployee1.SetDepartment("Sales");
            testEmployee1.SetEmployeeId("IV111");
            Console.WriteLine("Updated Employee: " + testEmployee1.GetName() + ", " + testEmployee1.GetDepartment());

            Console.WriteLine("\nMethod Overriding");
            testEmployee1.DisplayDetails();

            Console.WriteLine("\nMulti-level Inheritance");
            Manager manager1 = new Manager("Tarun", 25, "IV21", "Operations", 6);
            manager1.DisplayDetails();

            Console.WriteLine("\nLibrary System");
            Book book1 = new Book("Ikigai", "Héctor García & Francesc Miralles", 2017, "978-1786330895", "Self-Help");
            Magazine mag1 = new Magazine("Business Today", "Editorial Desk", 2025, 10, "Monthly");
            book1.DisplayDetails();
            mag1.DisplayDetails();

            Console.WriteLine("\nDone");
            Console.ReadKey();
        }
    }
}
