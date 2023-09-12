int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    int valorAoQuadrado = i * i;
    int valorAoCubo = i * i * i;
    Console.WriteLine($"{i} {valorAoQuadrado} {valorAoCubo}");
}