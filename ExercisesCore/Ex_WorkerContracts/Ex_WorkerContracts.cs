using ExercisesCore.Ex_WorkerContracts.Entities;
using ExercisesCore.Ex_WorkerContracts.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercisesCore.Ex_WorkerContracts
{
    class Ex_WorkerContracts
    {
        //static void Main(string[] args)
        //{
        //    Console.Write("Enter department's name: ");
        //    string department = Console.ReadLine();

        //    Console.Write("Enter worker data:\nName: ");
        //    string name = Console.ReadLine();
        //    Console.Write("Level(Junior / MidLevel / Senior): ");
        //    string level = Console.ReadLine();
        //    Console.Write("Base Salary: ");
        //    double baseSalary = double.Parse(Console.ReadLine());
        //    Console.Write("How many contracts to this worker? ");
        //    int contractsAmt = int.Parse(Console.ReadLine());

        //    Worker worker = new Worker { Name = name, Level = Enum.Parse<WorkerLevel>(level), BaseSalary = baseSalary, Department = new Department(department) };

        //    for (int i = 0; i < contractsAmt; i++)
        //    {
        //        Console.Write($"\nEnter #{i + 1} contract data:\nDate (DD/MM/YYYY): ");
        //        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        //        Console.Write("Value per hour: ");
        //        double valuePHour = double.Parse(Console.ReadLine());
        //        Console.Write("Duration (hours): ");
        //        worker.AddContract(new HourContract { Date = date, ValuePerHour = valuePHour, Hours = int.Parse(Console.ReadLine()) });
        //    }

        //    Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
        //    DateTime searchDate = DateTime.ParseExact(Console.ReadLine(), "MM/yyyy", CultureInfo.InvariantCulture);
        //    Console.WriteLine($"{worker}\nIncome for {searchDate.Month}/{searchDate.Year}: {worker.Income(searchDate.Year, searchDate.Month)}");
        //}
    }
}
