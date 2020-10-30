using Metodos_e_Classes_Abstrados.Entities.Enums;
using System;

namespace Metodos_e_Classes_Abstrados.Entities
{
    class Circle : Shape
    {

        public double Radius { get; set; }

        public Circle(double radius, Color color) :base (color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
