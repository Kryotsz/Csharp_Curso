using ExercicioExemploMetodosAbstratos.Entities.Enums;

namespace ExercicioExemploMetodosAbstratos.Entities
{
    abstract internal class Shape
    {
        public Color Color { get; set; }

        public Shape() { }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
