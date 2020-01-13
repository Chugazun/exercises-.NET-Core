using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using ExercisesCore.Ex_Products_LINQ.Entities;
using System.Globalization;

namespace ExercisesCore.Ex_Products_LINQ
{
    class Ex_Products_LINQ
    {
        //static void Main(string[] args)
        //{
        //    List<Product> products = new List<Product>();

        //    Console.Write("Enter the file's Full path: ");
        //    string sourceFilePath = Console.ReadLine();

        //    string[] lines = File.ReadAllLines(sourceFilePath);
        //    foreach (string line in lines)
        //    {
        //        string[] fields = line.Split(',');
        //        products.Add(new Product(fields[0], double.Parse(fields[1], CultureInfo.InvariantCulture)));
        //    }

        //    double test = products.Select(p => p.Price).Average();

        //    IEnumerable<string> namesResult = products.Where(p => p.Price < test).OrderByDescending(p => p.Name).Select(p => p.Name);

        //    Console.WriteLine("\nAverage Price: " + test.ToString("F2"));

        //    foreach (string productName in namesResult)
        //    {
        //        Console.WriteLine(productName);
        //    }            
        //}
    }
}
