using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Test_File_Names.Entities
{
    class Person
    {
        public string Name { get; set; }
        public string Desc { get; set; }

        public Person(string name, string desc)
        {
            Name = name;
            Desc = desc;
        }

        public override string ToString()
        {
            return Name + ": " + Desc;
        }
    }
}
