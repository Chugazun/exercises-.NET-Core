using ExercisesCore.Ex_Shapes_Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Shapes_Abstract.Entities
{
    class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double height, double width, Color color) : base (color)
        {
            Height = height;
            Width = width;
        }

        public override double Area()
        {
            return Height * Width;
        }
    }
}
