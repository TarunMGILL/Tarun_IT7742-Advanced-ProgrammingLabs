using System;

namespace Lab2_AdvancedProgramming
{
    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name)
        {
            this.name = name;
            age = 25;
        }

        public string GetName() { return name; }
        public void SetName(string name) { this.name = name; }

        public int GetAge() { return age; }
        public void SetAge(int age) { this.age = age; }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Name: " + name + ", Age: " + age);
        }
    }
}
