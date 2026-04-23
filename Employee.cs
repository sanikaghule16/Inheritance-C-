using System;
class Employee
{
    public string Name;
    public Employee(string name) { Name = name; }
    public virtual void Display() { Console.WriteLine("Employee Name: " + Name); }
}
class Programmer : Employee
{
    public string Language;
    public Programmer(string name, string lang) : base(name) { Language = lang; }
    public override void Display() { Console.WriteLine($"Programmer: {Name}, 
Language: {Language}"); }
}
class Manager : Employee
{
    public int TeamSize;
    public Manager(string name, int team) : base(name) { TeamSize = team; }
    public override void Display() { Console.WriteLine($"Manager: {Name}, Team Size:
{TeamSize}"); }
}
class Program
{
    static void Main()
    {
        Employee e1 = new Programmer("Alice", "C#");
        Employee e2 = new Manager("Bob", 5);
        e1.Display();
        e2.Display();
    }
}
