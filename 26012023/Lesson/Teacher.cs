using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Teacher:Employee
    {
        public Teacher(string name,string position):base(name,positon)
        {

        }
        public string Profession;
    }
}
