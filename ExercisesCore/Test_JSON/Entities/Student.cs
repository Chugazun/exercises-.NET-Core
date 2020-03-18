using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Test_JSON.Entities
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public Report Report { get; set; }

        public Student(string name, int age, string email, Report report)
        {
            Name = name;
            Age = age;
            Email = email;
            Report = report;
        }

        public Student()
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {Name}");
            sb.Append($"Age: {Age} ");
            sb.AppendLine("years old");
            sb.AppendLine($"Email: {Email}");
            sb.AppendLine($"Report info.");
            sb.Append(Report.ToString());

            return sb.ToString();
        }

    }
}
