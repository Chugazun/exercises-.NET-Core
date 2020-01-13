using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Linq;
using ExercisesCore.Ex_Worker_LINQ.Entities;

namespace ExercisesCore.Ex_Worker_LINQ
{
    class Ex_Worker_LINQ
    {
        //static void Main(string[] args)
        //{
        //    Console.Write("Enter the file's Full path: ");
        //    string sourceFilePath = Console.ReadLine();

        //    Console.Write("Enter salary: $");
        //    double salary = double.Parse(Console.ReadLine());

        //    List<Employee> employees = new List<Employee>();

        //    using(StreamReader sr = File.OpenText(sourceFilePath))
        //    {
        //        while(!sr.EndOfStream)
        //        {
        //            string[] fields = sr.ReadLine().Split(',');
        //            employees.Add(new Employee(fields[0], fields[1], double.Parse(fields[2], CultureInfo.InvariantCulture)));
        //        }
        //    }

        //    IEnumerable<string> emails = employees.Where(e => e.Salary > salary).OrderBy(e => e.Email).Select(e => e.Email);
        //    double sum = employees.Where(e => e.Name[0] == 'M').Select(e => e.Salary).Aggregate((x, y) => x + y);

        //    Console.WriteLine("\nEmail of employees with salaries higher than $" + salary.ToString("F2") + ":");
        //    foreach (string email in emails)
        //    {
        //        Console.WriteLine(email);
        //    }
        //    Console.WriteLine("\nSum of salary of people whose name starts with 'M': $" + sum.ToString("F2"));
        //}       
    }
}
