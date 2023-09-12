using System.Globalization;

string nome;
int quartos;
decimal precoProduto;

Console.WriteLine("Entre com seu nome completo:");
nome = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa?");
quartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço de um produto:");
precoProduto = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
string[] array = Console.ReadLine().Split(' ');

string ultimoNome = array[0];
int idade = int.Parse(array[1]);
double altura = double.Parse(array[2], CultureInfo.InvariantCulture);

Console.WriteLine(nome);
Console.WriteLine(quartos);
Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(ultimoNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));