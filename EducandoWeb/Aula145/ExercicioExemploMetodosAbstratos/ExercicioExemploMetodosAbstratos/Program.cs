using ExercicioExemploMetodosAbstratos.Entities;
using ExercicioExemploMetodosAbstratos.Entities.Enums;
using System.Globalization;

// cria a lista de formatos e a instancia
List<Shape> shapesList = new List<Shape>();

// entrada de dado de quantas formas serão lidas
Console.Write("Enter the number of shapes: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1;  i <= n; i++)
{
    // entrada de dados de qual forma é e sua cor
    Console.WriteLine();
    Console.WriteLine($"Shape #{i} data:");
    Console.Write("Rectangle or Circle (r/c)? ");
    char shape = char.Parse(Console.ReadLine());
    Console.Write("Color (Black/Blue/Red): ");
    Color color = Enum.Parse<Color>(Console.ReadLine());
    
    // se for retângulo
    if (shape == 'r')
    {
        // le os dados de largura e altura
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        // adiciona na lista de formatos um novo retângulo, passando os parâmetros largura, altura e cor
        shapesList.Add(new Rectangle(width, height, color));
    }
    else
    {
        // le o raio do círculo
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        // adiciona na lista um novo círculo, passando os parâmetros raio e cor
        shapesList.Add(new Circle(radius, color));
    }
}

// imprime na tela todas as áreas que estão na lista
Console.WriteLine();
Console.WriteLine("SHAPE AREAS:");
foreach (Shape s in shapesList)
{
    Console.WriteLine(s.Area().ToString("F2", CultureInfo.InvariantCulture));
}