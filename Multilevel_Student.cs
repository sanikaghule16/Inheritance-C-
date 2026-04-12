using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Inheritance
{
    class student
    {
        int roll_no;
        string name;
        public student(int roll_no, string name)
        {
            this.roll_no = roll_no;
            this.name = name;
        }
        public student() { }
        public void display()
        {
            Console.WriteLine("Roll no: " + roll_no);
            Console.WriteLine("Name: " + name);
        }
    }
}
