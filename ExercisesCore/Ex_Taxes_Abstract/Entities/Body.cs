using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Taxes_Abstract.Entities
{
    abstract class Body
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Body(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Taxes();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(": $ ");

            return sb.ToString();
        }
    }
}
