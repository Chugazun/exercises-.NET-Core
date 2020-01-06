using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Taxes_Abstract.Entities
{
    class IndividualBody : Body
    {
        public double HealthExpenses { get; set; }

        public IndividualBody(string name, double annualIncome, double healthExpenses) : base(name, annualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double Taxes()
        {
            double taxes = (AnnualIncome < 20000)? AnnualIncome * 0.15 : AnnualIncome * 0.25;           

            return (HealthExpenses > 0) ? taxes -= HealthExpenses * 0.5 : taxes;
        }
    }
}
