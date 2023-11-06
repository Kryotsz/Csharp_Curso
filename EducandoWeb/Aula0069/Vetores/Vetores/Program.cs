using System.Globalization;

int n = int.Parse(Console.ReadLine());
double soma = 0;
double[] alturas = new double[n];

for (int i = 0; i < n; i++)
{
    alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    soma += alturas[i];
}

double alturaMedia = soma/alturas.Length;

Console.WriteLine("AVERAGE HEIGHT = " + alturaMedia.ToString("F2", CultureInfo.InvariantCulture));