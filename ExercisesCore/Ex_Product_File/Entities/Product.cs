using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Product_File.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quant { get; set; }

        public Product(string name, double price, int quant)
        {
            Name = name;
            Price = price;
            Quant = quant;
        }

        public double TotalPrice()
        {
            return Price * Quant;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + ",");
            sb.Append(TotalPrice().ToString("F2"));

            return sb.ToString();
        }
    }
}
