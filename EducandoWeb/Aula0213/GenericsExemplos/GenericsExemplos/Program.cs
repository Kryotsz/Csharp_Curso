using GenericsExemplos;

PrintService printService = new PrintService();

Console.Write("How many values? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int value = int.Parse(Console.ReadLine());
    printService.AddValue(value);
}

printService.Print();
Console.WriteLine($"First: {printService.First()}");