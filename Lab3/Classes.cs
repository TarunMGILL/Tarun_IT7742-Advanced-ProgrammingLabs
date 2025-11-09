using System;

// ==============================
// Exercise 5 – Abstract Class Vehicle
// ==============================
public abstract class Vehicle
{
    public abstract void StartEngine();
    public void StopEngine()
    {
        Console.WriteLine("Engine has stopped");
    }
}

public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine is now running");
    }
}

public class Bike : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine is now running");
    }
}

// ==============================
// Exercise 6 – Abstract Properties in Shape
// ==============================
public abstract class Shape
{
    public abstract double Area { get; }
    public void DisplayArea()
    {
        Console.WriteLine("Area: " + Area);
    }
}

public class Triangle : Shape
{
    public double BaseLength { get; set; }
    public double Height { get; set; }
    public override double Area => 0.5 * BaseLength * Height;
}

public class Square : Shape
{
    public double Side { get; set; }
    public override double Area => Side * Side;
}

// ==============================
// Exercise 7 – Polymorphism with Abstract Class Appliance
// ==============================
public abstract class Appliance
{
    public abstract void Operate();
}

public class Oven : Appliance
{
    public override void Operate()
    {
        Console.WriteLine("Oven heating up");
    }
}

public class Fan : Appliance
{
    public override void Operate()
    {
        Console.WriteLine("Fan spinning air");
    }
}

// ==============================
// Exercise 8 – Abstract and Concrete Methods in Account
// ==============================
public abstract class Account
{
    public string AccountNo { get; set; }
    public double Balance { get; set; }
    public abstract double CalculateInterest();
    public void ShowDetails()
    {
        Console.WriteLine("Account No: " + AccountNo + " | Balance: " + Balance);
    }
}

public class FixedDeposit : Account
{
    public override double CalculateInterest()
    {
        return Balance * 0.06;
    }
}

public class CurrentAccount : Account
{
    public override double CalculateInterest()
    {
        return 0;
    }
}
