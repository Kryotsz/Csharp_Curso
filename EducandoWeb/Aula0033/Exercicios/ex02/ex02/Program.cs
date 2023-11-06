string[] coordenadas = Console.ReadLine().Split(' ');

int x = int.Parse(coordenadas[0]);
int y = int.Parse(coordenadas[1]);

while (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("primeiro");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("segundo");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("terceiro");
    }
    else
    {
        Console.WriteLine("quarto");
    }

    coordenadas = Console.ReadLine().Split(' ');

    x = int.Parse(coordenadas[0]);
    y = int.Parse(coordenadas[1]);
}