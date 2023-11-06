using System.Globalization;

string[] peca1 = Console.ReadLine().Split(' ');
string[] peca2 = Console.ReadLine().Split(' ');

int codigoPeca1 = int.Parse(peca1[0]);
int numeroPecas1 = int.Parse(peca1[1]);
decimal valorPeca1 = decimal.Parse(peca1[2], CultureInfo.InvariantCulture);

int codigoPeca2 = int.Parse(peca2[0]);
int numeroPecas2 = int.Parse(peca2[1]);
decimal valorPeca2 = decimal.Parse(peca2[2], CultureInfo.InvariantCulture);

decimal valorTotal = (numeroPecas1 * valorPeca1) + (numeroPecas2 * valorPeca2);

Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));