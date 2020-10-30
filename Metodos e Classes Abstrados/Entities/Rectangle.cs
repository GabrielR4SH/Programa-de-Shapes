
using Metodos_e_Classes_Abstrados.Entities.Enums;

namespace Metodos_e_Classes_Abstrados.Entities
{
    class Rectangle : Shape
    {

        public double Width { get; set; }

        public double Height { get; set; }

        public Rectangle (double width, double height , Color color) : base(color)
        {
            Width = width;
            Height = height;

        }
        public override double Area()
        {
            return 0;
        }
    }
}
