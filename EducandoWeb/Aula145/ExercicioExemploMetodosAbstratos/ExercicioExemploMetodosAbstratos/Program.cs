using ExercicioExemploMetodosAbstratos.Entities;
using ExercicioExemploMetodosAbstratos.Entities.Enums;
using System.Globalization;

List<Shape> shapesList = new List<Shape>();

Console.Write("Enter the number of shapes: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1;  i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Shape #{i} data:");
    Console.Write("Rectangle or Circle (r/c)? ");
    char shape = char.Parse(Console.ReadLine());
    Console.Write("Color (Black/Blue/Red): ");
    Color color = Enum.Parse<Color>(Console.ReadLine());
    
    if (shape == 'r')
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        shapesList.Add(new Rectangle(width, height, color));
    }
    else
    {
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        shapesList.Add(new Circle(radius, color));
    }
}

Console.WriteLine();
Console.WriteLine("SHAPE AREAS:");
foreach (Shape s in shapesList)
{
    Console.WriteLine(s.Area().ToString("F2", CultureInfo.InvariantCulture));
}