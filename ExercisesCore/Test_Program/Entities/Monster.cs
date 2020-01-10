using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Test_Program.Entities
{
    class Monster : Entity
    {
        public string Name { get; set; }
        
        public Monster (string name, int hp) : base(hp)
        {            
            Name = name;
        }       
    }
}
