using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Inheritance
{
    class Result : Test
    {
        int total;
        public Result(int roll_no, string name, int marks1, int marks2)
        : base(roll_no, name, marks1, marks2)
        {
            total = getMarks1() + getMarks2();
        }
        public void display()
        {
            base.display();
            Console.WriteLine("Total: " + total);
        }
    }
}
