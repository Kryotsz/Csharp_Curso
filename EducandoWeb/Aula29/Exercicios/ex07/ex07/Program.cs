using System.Globalization;

string[] coordenadas = Console.ReadLine().Split(' ');

double x = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
double y = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);

if (x == 0.0 && y == 0.0)
{
    Console.WriteLine("Origem");
}
else if (x > 0.0 && y > 0.0)
{
    Console.WriteLine("Q1");
}
else if (x < 0.0 && y > 0.0)
{
    Console.WriteLine("Q2");
}
else if (x < 0.0 && y < 0.0)
{
    Console.WriteLine("Q3");
}
else
{
    Console.WriteLine("Q4");
}