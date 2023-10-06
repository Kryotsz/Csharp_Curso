using ExercicioExemploMetodosAbstratos.Entities.Enums;

namespace ExercicioExemploMetodosAbstratos.Entities
{
    // declara a classe como abstrata, já que ela tem um método abstrato
    abstract internal class Shape
    {
        // cria a propriedade Color
        public Color Color { get; set; }

        // construtor padrão
        public Shape() { }

        // cria um construtor que recebe somente a propriedade color
        public Shape(Color color)
        {
            Color = color;
        }

        // cria um método Area abstrato
        public abstract double Area();
    }
}
