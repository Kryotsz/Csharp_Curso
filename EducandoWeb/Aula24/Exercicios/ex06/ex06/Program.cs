using System.Globalization;

string[] medidas = Console.ReadLine().Split(' ');

double a = double.Parse(medidas[0], CultureInfo.InvariantCulture);
double b = double.Parse(medidas[1], CultureInfo.InvariantCulture);
double c = double.Parse(medidas[2], CultureInfo.InvariantCulture);

Console.WriteLine("TRIANGULO: " + ((a * c)/2).ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("CIRCULO: " + (3.14159 * Math.Pow(c, 2)).ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("TRAPEZIO: " + (((a + b) * c)/2).ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("QUADRADO: " + (b * b).ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("RETANGULO: " + (a * b).ToString("F3", CultureInfo.InvariantCulture));