using System.Globalization;

int N = int.Parse(Console.ReadLine());

for  (int i = 0; i < N; i++)
{
    string[] valores = Console.ReadLine().Split(' ');
    int a = int.Parse(valores[0]);
    int b = int.Parse(valores[1]);

   if (b == 0)
    {
        Console.WriteLine("divisao impossivel");
    }
    else
    {
        double resultadoDivisao = (double) a / b;
        Console.WriteLine(resultadoDivisao.ToString("F1", CultureInfo.InvariantCulture));
    }
}