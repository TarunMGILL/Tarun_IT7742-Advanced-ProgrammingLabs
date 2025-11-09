using System;
using System.Collections.Generic;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Exercise 5: Vehicle ===");
            Vehicle v1 = new Car();
            Vehicle v2 = new Bike();
            v1.StartEngine();
            v1.StopEngine();
            v2.StartEngine();
            v2.StopEngine();

            Console.WriteLine("\n=== Exercise 6: Shape ===");
            Triangle t = new Triangle { BaseLength = 6, Height = 4 };
            Square s = new Square { Side = 5 };
            t.DisplayArea();
            s.DisplayArea();

            Console.WriteLine("\n=== Exercise 7: Appliance ===");
            List<Appliance> devices = new List<Appliance>
            {
                new Oven(),
                new Fan()
            };
            foreach (var d in devices)
            {
                d.Operate();
            }

            Console.WriteLine("\n=== Exercise 8: Account ===");
            FixedDeposit fd = new FixedDeposit { AccountNo = "FD500", Balance = 3000 };
            CurrentAccount ca = new CurrentAccount { AccountNo = "CA600", Balance = 1800 };
            fd.ShowDetails();
            Console.WriteLine("Interest: " + fd.CalculateInterest());
            ca.ShowDetails();
            Console.WriteLine("Interest: " + ca.CalculateInterest());

            Console.WriteLine("\n--- End of Lab 3 Output ---");
        }
    }
}
