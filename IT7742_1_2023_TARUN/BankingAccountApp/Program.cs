using System;
using System.Globalization;

namespace BankingAccountApp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Simple Banking Application");
            Console.WriteLine("---------------------------");

            var cust = new Customer(501, "Tarun Kumar", "testtarun@bankname.com", true);

            var everyday = new EverydayAccount(101, 800m);
            var invest = new InvestmentAccount(102, 1500m, 5m, 20m);
            var omni = new OmniAccount(103, 1200m, 3m, 100m, 10m);

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Customer: {cust.GetName()} (Staff: {cust.IsStaff()})");
                Console.WriteLine("Choose Account:");
                Console.WriteLine("1. Everyday");
                Console.WriteLine("2. Investment");
                Console.WriteLine("3. Omni");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");
                var choice = Console.ReadLine();

                if (choice == "0")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                Account acc = choice switch
                {
                    "1" => everyday,
                    "2" => invest,
                    "3" => omni,
                    _ => everyday
                };

                Console.WriteLine();
                Console.WriteLine("Select Operation:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Add Interest");
                Console.WriteLine("4. Show Info");
                Console.WriteLine("x. Back");
                Console.Write("Enter choice: ");
                var action = Console.ReadLine();

                if (action == "x")
                    continue;

                switch (action)
                {
                    case "1":
                        Console.Write("Enter amount: ");
                        if (decimal.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out var depAmt))
                        {
                            acc.Deposit(depAmt);
                            Console.WriteLine(acc.Last());
                        }
                        break;

                    case "2":
                        Console.Write("Enter amount: ");
                        if (decimal.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out var wAmt))
                        {
                            acc.Withdraw(wAmt, cust.IsStaff());
                            Console.WriteLine(acc.Last());
                        }
                        break;

                    case "3":
                        acc.CalculateInterest();
                        Console.WriteLine(acc.Last());
                        break;

                    case "4":
                        Console.WriteLine($"Account {acc.GetAccountID()} | Balance: {acc.GetBalance():0.00}");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
