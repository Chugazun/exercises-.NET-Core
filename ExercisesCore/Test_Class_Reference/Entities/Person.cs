using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Test_Class_Reference.Entities
{
    class Person
    {
        private string Name;

        public Person(string name)
        {
            Name = name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public Person GetPerson()
        {
            return this;
        }

    }
}
