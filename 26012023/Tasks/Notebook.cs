using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Notebook:Product
    {
        public Notebook(string name,double price):base(name,price)
        {

        }
        public int RAM;
        public int Storage;

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} - Price: {Price} - RAM: {RAM} - Storage: {Storage}");
        }
    }
}
