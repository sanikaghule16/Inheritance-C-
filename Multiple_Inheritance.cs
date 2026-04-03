using System;
// Interface 1
interface Gross
{
    void TADA();
    void Gross_sal();
}
// Base class
class Employee
{
    public string name;
    public double basic_sal;
    public void GetData()
    {
        Console.Write("Enter Employee Name: ");
        name = Console.ReadLine();
        Console.Write("Enter Basic Salary: ");
        basic_sal = Convert.ToDouble(Console.ReadLine());
    }
}
// Derived class that implements interface
class Salary : Employee, Gross
{
    double hra, da, gross;
    public void TADA()
    {
        hra = 0.20 * basic_sal;   // 20% HRA
        da = 0.10 * basic_sal;    // 10% DA
    }
    public void Gross_sal()
    {
        gross = basic_sal + hra + da;
    }
    public void Disp_sal()
    {
        Console.WriteLine("\n--- Employee Salary Details ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Basic Salary: " + basic_sal);
        Console.WriteLine("HRA: " + hra);
        Console.WriteLine("DA: " + da);
        Console.WriteLine("Gross Salary: " + gross);
    }
}
// Main class
class Program
{
    static void Main(string[] args)
    {
        Salary s = new Salary();
        s.GetData();
        s.TADA();
        s.Gross_sal();
        s.Disp_sal();
        Console.ReadLine();
    }
}
