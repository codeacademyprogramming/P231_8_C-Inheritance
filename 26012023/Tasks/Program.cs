using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bicycle Task
            //Console.WriteLine("Velosiped sayi:");
            //string countStr = Console.ReadLine();
            //int count = Convert.ToInt32(countStr);

            //Bicycle[] bicycles = new Bicycle[count];


            //for (int i = 0; i < bicycles.Length; i++)
            //{

            //    string brand;
            //    do
            //    {
            //        Console.WriteLine("Brand: ");
            //        brand = Console.ReadLine();
            //    } while (string.IsNullOrWhiteSpace(brand));

            //    string model;
            //    do
            //    {
            //        Console.WriteLine("Model: ");
            //        model = Console.ReadLine();
            //    } while (string.IsNullOrWhiteSpace(model));


            //    Bicycle bc = new Bicycle
            //    {
            //        Brand = brand,
            //        Model = model
            //    };

            //    bicycles[i] = bc;
            //}

            //Console.WriteLine("1. Butun velosipedlere bax");
            //Console.WriteLine("2. Velosipedler arasinda model adina gore axtaris et");

            //Console.WriteLine("Emeliyyat secin:");
            //string opr = Console.ReadLine();

            //if (opr == "1")
            //{
            //    foreach (var item in bicycles)
            //    {
            //        Console.WriteLine($"Brand: {item.Brand} - Model: {item.Model} - Millage: {item.Mileage}");
            //    }
            //}
            //else if (opr == "2")
            //{
            //    Console.WriteLine("Modeli daxil edin:");
            //    string wantedModel = Console.ReadLine();

            //    foreach (var item in bicycles)
            //    {
            //        if (item.Model.Contains(wantedModel))
            //            Console.WriteLine($"Brand: {item.Brand} - Model: {item.Model} - Millage: {item.Mileage}");
            //    }
            //}
            #endregion

            #region Product task

            Product product1 = new Product("Mehsul 1", 100);
            Phone phone1 = new Phone("Iphone 11", 1200) { Camera = 16 };
            Notebook notebook1 = new Notebook("XPS 15", 2300) { Storage = 512, RAM = 16 };

            notebook1.ShowInfo();

            Phone[] phones = new Phone[0];


            string option;
            do
            {
                Console.WriteLine("1. Telefonlara bax");
                Console.WriteLine("2. Adina gore axtaris et");
                Console.WriteLine("3. Telefon elave et");
                Console.WriteLine("0. Cix");

                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Butun telefonlari gostereceksiniz");
                        break;
                    case "2":
                        Console.WriteLine("Telefonlar icerisinde axtaris et");
                        break;
                    case "3":
                        Console.WriteLine("Telefon datalarini consoledan gorutub, yeni telefon yaradib, arraye elave etmek");
                        break;
                    case "0":
                        option = "-1";
                        Console.WriteLine("Eminsinizmi? y/n");
                        if(Console.ReadLine() == "y")
                        {
                            option = "0";
                        }
                        break;
                    default:
                        Console.WriteLine("Yanlis secim etdiniz, yeniden secin!");
                        break;
                }
            } while (option!="0");
            






            #endregion


        }
    }
}
