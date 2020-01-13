using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Products_LINQ.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
