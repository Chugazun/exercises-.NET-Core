using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Test_Class_Reference.Entities
{
    class Control
    {
        public static string ChangeName(Person person, string newName)
        {
            Person aux = person;
            string oldName = aux.GetName();
            aux.SetName(newName);

            return oldName;
        }
    }
}
