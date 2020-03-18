using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Test_RandomStuff.Entities
{
    class StatusSheet
    {
        private int _poison;
        public int Poison
        {
            get => _poison;
            set
            {
                _poison = value;
                Console.WriteLine("Gained " + value + " Poison!");
            }
        }
    }
}
