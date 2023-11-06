using System.Globalization;

decimal salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
decimal imposto;

if (salario >= 0.00M && salario <= 2000.00M)
{
    Console.WriteLine("Isento");
    return;
}
else if (salario > 2000.00M && salario <= 3000.00M)
{
    imposto = (salario - 2000.00M) * 0.08M;
    
}
else if (salario > 3000.01M && salario <= 4500.00M)
{
    imposto = (salario - 3000.00M) * 0.18M + 1000.00M * 0.08M;
}
else
{
    imposto = (salario - 4500.00M) * 0.28M + 1500.00M * 0.18M + 1000.00M * 0.08M;
}

Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));