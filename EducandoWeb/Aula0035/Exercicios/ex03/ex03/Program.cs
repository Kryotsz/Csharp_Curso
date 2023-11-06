using System.Globalization;

int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string[] valoresReais = Console.ReadLine().Split(' ');
    double a = double.Parse(valoresReais[0], CultureInfo.InvariantCulture);
    double b = double.Parse(valoresReais[1], CultureInfo.InvariantCulture);
    double c = double.Parse(valoresReais[2], CultureInfo.InvariantCulture);

    double mediaPonderada = (a * 2 + b * 3 + c * 5) / 10;

    Console.WriteLine(mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
}