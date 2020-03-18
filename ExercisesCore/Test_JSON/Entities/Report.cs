using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Test_JSON.Entities
{
    class Report
    {
        public double Grade_1 { get; set; }
        public double Grade_2 { get; set; }
        public double Grade_3 { get; set; }
        public double FinalGrade { get; set; }

        public Report()
        {

        }

        public Report(double grade_1, double grade_2, double grade_3)
        {
            Grade_1 = grade_1;
            Grade_2 = grade_2;
            Grade_3 = grade_3;
            CalcFinalGrade();
        }

        public void CalcFinalGrade()
        {
            FinalGrade = (Grade_1 + Grade_2 + Grade_3) / 3;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Grade 1: {Grade_1}");
            sb.AppendLine($"Grade 2: {Grade_2}");
            sb.AppendLine($"Grade 3: {Grade_3}");
            sb.AppendLine($"Final Grade: {FinalGrade}");

            return sb.ToString();
        }
    }
}
