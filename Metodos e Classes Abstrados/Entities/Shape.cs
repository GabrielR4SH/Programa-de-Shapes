using Metodos_e_Classes_Abstrados.Entities.Enums;

namespace Metodos_e_Classes_Abstrados.Entities
{
 abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
