using System.Globalization;

double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double desconto;

// If e Else normal
if (preco < 20.0)
{
    desconto = preco * 0.1;
}
else
{
    desconto = preco * 0.05;
}

Console.WriteLine(desconto);

// If ternário (Expressão Condicional Ternária)
desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

Console.WriteLine(desconto);