int alcool = 0;
int gasolina = 0;
int diesel = 0;

int codigo = int.Parse(Console.ReadLine());

while (codigo != 4)
{
    while (codigo < 1 || codigo > 4)
    {
        codigo = int.Parse(Console.ReadLine());
    }

    if (codigo == 1)
    {
        alcool++;
    }
    else if (codigo == 2)
    {
        gasolina++;
    }
    else if (codigo == 3)
    {
        diesel++;
    }

    codigo = int.Parse(Console.ReadLine());
}

Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine($"Alcool: {alcool}");
Console.WriteLine($"Gasolina: {gasolina}");
Console.WriteLine($"Diesel: {diesel}");