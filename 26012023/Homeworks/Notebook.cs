using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    internal class Notebook
    {
        public Notebook(string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
        }

        public Notebook(string brand, string model, double price):this(brand,model)
        {
            this.Price = price;
        }

        public Notebook(string brand,string model, double price, double discountPercent):this(brand,model,price)
        {
            this.DiscountPercent = discountPercent;
        }

        public string Brand;
        public string Model;
        public double Price;
        public double DiscountPercent;
        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Price: {Price}");
        }
    }
}
