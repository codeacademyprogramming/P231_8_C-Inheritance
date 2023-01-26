using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Student:Human
    {
        public Student(string name,string groupNo):base(name)
        {
            this.GroupNo = groupNo;
        }

        public Student(string name):base(name)
        {

        }
        public string GroupNo;
    }
}
