using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_WorkerContracts.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public double totalValue()
        {
            return ValuePerHour * Hours;
        }

    }
}
