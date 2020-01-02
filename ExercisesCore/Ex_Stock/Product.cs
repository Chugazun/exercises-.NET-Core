using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Stock
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quant;

        public Product(string name, double price, int quant)
        {
            Name = name;
            Price = price;
            Quant = quant;
        }

        public Product()
        {

        }

        public double TotalValueInStock()
        {
            return Price * Quant;
        }

        public void AddProducts(int quant)
        {
            Quant += quant;
        }

        public void RemoveProducts(int quant)
        {
            Quant -= quant;
        }

        public override string ToString()
        {
            return $"{Name}, ${Price.ToString("F2")}, {Quant} unidades, Total: ${TotalValueInStock().ToString("F2")}";
        }
    }
}
