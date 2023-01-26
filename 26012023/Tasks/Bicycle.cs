using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Bicycle
    {
        public string Brand;
        public string Model;
        public double Mileage;


        public void Drive(double km)
        {
            this.Mileage += km;
        }
    }
}
