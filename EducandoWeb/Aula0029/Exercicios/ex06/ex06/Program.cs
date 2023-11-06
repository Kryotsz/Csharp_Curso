using System.Globalization;

double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

string intervalo = "";

if (valor >= 0 && valor <= 25)
{
    intervalo = "[0,25]";
}
else if (valor > 25 && valor <= 50)
{
    intervalo = "(25,50]";
}
else if (valor > 50 && valor <= 75)
{
    intervalo = "(50,75]";
}
else if (valor > 75 && valor <= 100)
{
    intervalo = "(75,100]";
}
else
{
    intervalo = "Fora de intervalo";
    Console.WriteLine(intervalo);
    return;
}

Console.WriteLine($"Intervalo {intervalo}");