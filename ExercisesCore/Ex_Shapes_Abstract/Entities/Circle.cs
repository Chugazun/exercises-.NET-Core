using ExercisesCore.Ex_Shapes_Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Shapes_Abstract.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
