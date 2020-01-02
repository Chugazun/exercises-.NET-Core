using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Vector_Avg_Price
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
