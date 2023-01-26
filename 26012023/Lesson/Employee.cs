using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Employee:Human
    {
        public Employee(string name,string positon):base(name)
        {
            this.Position = positon;
        }
        public string Position;
        public double Salary;
    }
}
