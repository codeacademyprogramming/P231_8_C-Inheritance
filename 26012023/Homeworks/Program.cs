using System;

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            new Notebook("Apple", "Macbook 1", 1200, 10);

            Notebook[] notebooks = new Notebook[4];

            //notebooks[0] = new Notebook("Lenovo", "thinkpad P1", 2300);
            

            //notebooks[1] = new Notebook("Apple", "Macbook Pro 15") { Price = 550 };
            //notebooks[2] = new Notebook("Apple", "Macbook Air 13") { Price = 250 };
            //notebooks[3] = new Notebook("Asus", "ROG") { Price = 3400 };

            for (int i = 0; i < notebooks.Length; i++)
            {
                string brand;
                do
                {
                    Console.WriteLine("Brand:");
                    brand = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(brand) || brand.Length<2);
               

                Console.WriteLine("Model:");
                string model = Console.ReadLine();

                Console.WriteLine("Price");
                string priceStr = Console.ReadLine();
                double price = Convert.ToDouble(priceStr);

                var nt = new Notebook(brand, model, price);

                notebooks[i] = nt;
            }

            double totalPrice = 0;
            foreach (var item in notebooks)
            {
                totalPrice += item.Price;
            }

            var result = totalPrice / notebooks.Length;

            Console.WriteLine(result);
        }

    }
}
