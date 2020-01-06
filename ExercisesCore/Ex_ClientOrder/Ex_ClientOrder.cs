using ExercisesCore.Ex_ClientOrder.Entities;
using ExercisesCore.Ex_ClientOrder.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercisesCore.Ex_ClientOrder
{
    class Ex_ClientOrder
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Client Data:\nName: ");
            string name = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("\nEnter order Data:\nStatus: ");
            Order order = new Order(DateTime.Now, Enum.Parse<OrderStatus>(Console.ReadLine()), new Client(name, email, birthDate));

            Console.Write("How many items in this order? ");
            int quant = int.Parse(Console.ReadLine());

            for (int i = 0; i < quant; i++)
            {
                Console.Write($"\nEnter #{i + 1} item data:\nProduct name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                order.AddItem(new OrderItem(int.Parse(Console.ReadLine()), productName, productPrice));
            }
            Console.WriteLine("\nOrder Summary:\n" + order);
        } 
    }
}
