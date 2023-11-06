using ExercicioExemploMetodosAbstratos.Entities.Enums;

namespace ExercicioExemploMetodosAbstratos.Entities
{
    // classe Circle que herda da classe Shape
    internal class Circle: Shape
    {
        // declara a propriedade raio
        public double Radius { get; set; }

        // construtor de 2 parâmetros
        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        // sobrescreve o método abstrato Area do Shape
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
