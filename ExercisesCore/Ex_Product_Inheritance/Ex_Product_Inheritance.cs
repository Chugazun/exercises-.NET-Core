using ExercisesCore.Ex_Product_Inheritance.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercisesCore.Ex_Product_Inheritance
{
    class Ex_Product_Inheritance
    {
        //static void Main(string[] args)
        //{
        //    List<Product> products = new List<Product>();

        //    Console.Write("Enter the number of products: ");
        //    int productQuant = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < productQuant; i++)
        //    {
        //        Console.Write($"\nProduct {i + 1} Data:\nCommon, used or imported (c/u/i)? ");
        //        char productType = char.Parse(Console.ReadLine());

        //        Console.Write("Name: ");
        //        string name = Console.ReadLine();

        //        Console.Write("Price: ");
        //        double price = double.Parse(Console.ReadLine());

        //        switch (productType)
        //        {
        //            case 'c':
        //                products.Add(new Product(name, price));
        //                break;

        //            case 'u':
        //                Console.Write("Manufactured date (DD/MM/YYYY): ");
        //                products.Add(new UsedProduct(name, price, DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture)));
        //                break;

        //            case 'i':
        //                Console.Write("Customs fee: ");
        //                products.Add(new ImportedProduct(name, price, double.Parse(Console.ReadLine())));
        //                break;

        //            default:
        //                Console.WriteLine("Invalid option!");
        //                break;
        //        }
        //    }
        //    Console.WriteLine("\nPrice Tags:");
        //    foreach (Product item in products)
        //    {
        //        Console.WriteLine(item.PriceTag());
        //    }
        //}
    }
}
