using ExercicioVetores2;
using System.Globalization;

double soma = 0;

int n = int.Parse(Console.ReadLine());

Produto[] produtos = new Produto[n];

for (int i = 0; i < n; i++)
{
    Produto p = new Produto();
    p.Nome = Console.ReadLine();
    p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    produtos[i] = p;
    soma += p.Preco;
}

double precoMedio = soma / n;

Console.WriteLine("AVERAGE PRICE = " + precoMedio.ToString("F2", CultureInfo.InvariantCulture));
