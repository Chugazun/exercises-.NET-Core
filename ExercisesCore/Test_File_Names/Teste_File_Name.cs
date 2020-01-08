using ExercisesCore.Test_File_Names.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExercisesCore.Test_File_Names
{
    class Teste_File_Name
    {
        static void Main(string[] args)
        {
            try
            {
                string sourceFolderPath = @"E:\Stuff\Studies\c#\ExercisesCore\ExercisesCore\Test_File_Names";
                string namesFile = sourceFolderPath + @"\Friends.txt";
                string descFile = sourceFolderPath + @"\Description.txt";

                string[] names = File.ReadAllLines(namesFile);
                string[] descriptions = File.ReadAllLines(descFile);

                string targetFolderPath = sourceFolderPath + @"\out";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFolderPath + @"\summary.txt"))
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        Person person = new Person(names[i], descriptions[i]);
                        sw.WriteLine(person.ToString());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }
    }
}
