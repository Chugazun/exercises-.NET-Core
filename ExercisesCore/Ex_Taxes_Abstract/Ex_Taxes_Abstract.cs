using ExercisesCore.Ex_Taxes_Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Taxes_Abstract
{
    class Ex_Taxes_Abstract
    {
        //static void Main(string[] args)
        //{
        //    List<Body> taxpayers = new List<Body>();

        //    Console.Write("Enter the number of employees: ");
        //    int taxPayersNum = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < taxPayersNum; i++)
        //    {
        //        Console.Write($"\nTax payer {i + 1} Data:\nIndividual or Company (i/c)? ");
        //        char bodyType = char.Parse(Console.ReadLine());

        //        Console.Write("Name: ");
        //        string name = Console.ReadLine();

        //        Console.Write("Annual income: ");
        //        double annualIncome = double.Parse(Console.ReadLine());

        //        if (bodyType == 'i')
        //        {
        //            Console.Write("Health expenditures: ");
        //            taxpayers.Add(new IndividualBody(name, annualIncome, double.Parse(Console.ReadLine())));
        //        }
        //        else
        //        {
        //            Console.Write("Number of employees: ");
        //            taxpayers.Add(new CompanyBody(name, annualIncome, int.Parse(Console.ReadLine())));
        //        }
        //    }
        //    Console.WriteLine("\nTaxes paid");

        //    double totalTaxes = 0;
        //    foreach (Body item in taxpayers)
        //    {
        //        Console.WriteLine(item + item.Taxes().ToString("F2"));
        //        totalTaxes += item.Taxes();
        //    }
        //    Console.WriteLine("\nTotal taxes: $ " + totalTaxes.ToString("F2"));
        //}
    }
}
