using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student("Hikmet","P111")
            {
                Age = 18,
                Surname = "Abbasov",
            };


            Teacher tc1 = new Teacher("Abbas", "Teacher");


            //Human human1 = new Human
            //{
            //    Name = "Abbas",
            //    Surname = "Abbasov",
            //    Age = 34
            //};
        }
    }
}
