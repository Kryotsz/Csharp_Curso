int N = int.Parse(Console.ReadLine());
int fatorial = 1;

for (int i = 1; i <= N; i++)
{
    fatorial *= i;
}

Console.WriteLine(fatorial);