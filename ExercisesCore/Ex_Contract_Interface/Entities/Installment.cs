using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Contract_Interface.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment()
        {

        }       

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy") + " - " + Amount.ToString("F2");
        }
    }
}
