using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_ClientOrder.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, string productName, double productPrice)
        {
            Quantity = quantity;
            Price = productPrice;
            Product = new Product(productName, productPrice);
        }

        public double SubTotal()
        {            
            return Price * Quantity;
        }
    }
}
