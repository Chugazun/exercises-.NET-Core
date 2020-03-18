using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Test_Monty_Hall.Entities
{
    class Participant
    {
        public int Choice { get; set; }
        public bool Result { get; set; }

        public Participant(int choice)
        {
            Choice = choice;
            Result = false;
        }
    }
}
