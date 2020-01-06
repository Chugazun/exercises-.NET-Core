using ExercisesCore.Ex_Shapes_Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Shapes_Abstract.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
