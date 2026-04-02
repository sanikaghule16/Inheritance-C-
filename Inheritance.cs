namespace InheritancePersonStudent
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }
        public
     virtual void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Birth Date: {BirthDate.ToShortDateString()}");
        }
    }
    public class Student : Person
    {
        public string Course { get; set; }
        public Student(string name, DateTime birthDate, string course) : base(name, 
birthDate)
        {
            Course = course;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Course: {Course}");
        }
    }
    public class Instructor : Person
    {
        public double Salary { get; set; }
        public Instructor(string name, DateTime birthDate, double salary) : 
base(name, birthDate)
        {
            Salary = salary;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Salary: {Salary}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("RAm", new DateTime(1995, 1, 1), "Computer
Science");
            Instructor instructor = new Instructor("Shyam", new DateTime(1980, 5, 
15), 50000.0);
            student.Print();
            Console.WriteLine();
            instructor.Print();
        }
    }
}
