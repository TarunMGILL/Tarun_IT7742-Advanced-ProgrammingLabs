using System;

namespace Lab2_AdvancedProgramming
{
    class Employee : Person
    {
        protected string employeeId;
        protected string department;

        public Employee(string name, int age, string id, string dept) : base(name, age)
        {
            employeeId = id;
            department = dept;
        }

        public Employee(string id, string dept) : base("Tarun", 25)
        {
            employeeId = id;
            department = dept;
        }

        public string GetEmployeeId() { return employeeId; }
        public void SetEmployeeId(string id) { employeeId = id; }

        public string GetDepartment() { return department; }
        public void SetDepartment(string dept) { department = dept; }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Employee ID: " + employeeId + ", Department: " + department);
        }
    }
}
