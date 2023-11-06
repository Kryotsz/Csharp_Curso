int valorInteiro;
int soma = 0;

Console.Write("Quantos números inteiros você vai digitar? ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    Console.Write($"Valor #{i}: ");
    valorInteiro = int.Parse(Console.ReadLine());
    soma += valorInteiro;
}

Console.WriteLine($"Soma = {soma}");