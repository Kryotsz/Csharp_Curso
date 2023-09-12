using System.Globalization;

string[] valores = Console.ReadLine().Split(' ');

int codigoItem = int.Parse(valores[0]);
int quantidadeItem = int.Parse(valores[1]);

decimal valorFinal;

if (codigoItem == 1)
{
    valorFinal = quantidadeItem * 4.00M;
}
else if (codigoItem == 2)
{
    valorFinal = quantidadeItem * 4.50M;
}
else if (codigoItem == 3)
{
    valorFinal = quantidadeItem * 5.00M;
}
else if (codigoItem == 4) 
{
    valorFinal = quantidadeItem * 2.00M;
}
else
{
    valorFinal = quantidadeItem * 1.50M;
}

Console.WriteLine("Total: R$ " + valorFinal.ToString("F2", CultureInfo.InvariantCulture));