using ExercicioExemploMetodosAbstratos.Entities.Enums;

namespace ExercicioExemploMetodosAbstratos.Entities
{
    // classe Rectangle que herda da classe Shape
    internal class Rectangle : Shape
    {
        // declara as propriedades de largura e altura
        public double Width { get; set; }
        public double Height { get; set; }

        // construtor de 3 parâmetros
        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        // sobrescreve o método abstrato Area do Shape
        public override double Area()
        {
            return Width * Height;
        }
    }
}
