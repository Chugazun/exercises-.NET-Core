using ExercisesCore.Ex_Product_File.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;

namespace ExercisesCore.Ex_Product_File
{
    class Ex_Product_File
    {
        //static void Main(string[] args)
        //{
        //    Console.Write("Enter the file full path: ");
        //    string sourceFilePath = Console.ReadLine();

        //    try
        //    {
        //        string[] lines = File.ReadAllLines(sourceFilePath);

        //        string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
        //        string targetFolderPath = sourceFolderPath + @"\out";
        //        string targetFilePath = targetFolderPath + @"\summary.csv";

        //        Directory.CreateDirectory(targetFolderPath);

        //        using (StreamWriter sw = File.AppendText(targetFilePath))
        //        {
        //            foreach (string item in lines)
        //            {
        //                string[] fields = item.Split(',');

        //                Product product = new Product(fields[0], double.Parse(fields[1], CultureInfo.InvariantCulture), int.Parse(fields[2]));
        //                sw.WriteLine(product.ToString(), CultureInfo.InvariantCulture);                        
        //            }
        //        }
        //    }
        //    catch(IOException e)
        //    {
        //        Console.Write("An Error Occurred\n" + e.Message);
        //    }            
        //} 
    }
}
