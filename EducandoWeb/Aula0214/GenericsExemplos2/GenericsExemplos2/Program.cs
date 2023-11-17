using GenericsExemplos2;

// agora quando for instanciar o objeto, tem que declarar o tipo
PrintService<int> printService = new PrintService<int>();

Console.Write("How many values? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    // se o tipo for incorreto, o compilador avisará
    int value = int.Parse(Console.ReadLine());
    printService.AddValue(value);
}

printService.Print();
Console.WriteLine($"First: {printService.First()}");