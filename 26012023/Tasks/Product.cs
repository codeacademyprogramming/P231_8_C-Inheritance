using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Product
    {
        public Product(string name,double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name;
        public double Price;

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} - Price: {Price}");
        }
    }
}
