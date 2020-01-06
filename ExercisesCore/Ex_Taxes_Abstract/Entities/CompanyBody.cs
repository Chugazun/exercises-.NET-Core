using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Taxes_Abstract.Entities
{
    class CompanyBody : Body
    {
        public int EmployeeNum { get; set; }

        public CompanyBody(string name, double annualIncome, int employeeNum) : base(name, annualIncome)
        {
            EmployeeNum = employeeNum;
        }

        public override double Taxes()
        {
            return (EmployeeNum > 10) ? AnnualIncome * 0.14 : AnnualIncome * 0.16;
        }
    }
}
