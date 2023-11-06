string[] numerosInteiros = Console.ReadLine().Split(' ');

int a = int.Parse(numerosInteiros[0]);
int b = int.Parse(numerosInteiros[1]);

if (b % a == 0 || a % b == 0)
{
    Console.WriteLine("São Multiplos");
}
else
{
    Console.WriteLine("Nao sao Multiplos");
}