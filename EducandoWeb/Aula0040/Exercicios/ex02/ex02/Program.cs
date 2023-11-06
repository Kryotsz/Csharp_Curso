using ex02;
using System.Globalization;

Funcionario A = new Funcionario();
Funcionario B = new Funcionario();

Console.WriteLine("Dados do primeiro funcionário:");
Console.Write("Nome: ");
A.Nome = Console.ReadLine();
Console.Write("Salário: ");
A.Salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do primeiro funcionário:");
Console.Write("Nome: ");
B.Nome = Console.ReadLine();
Console.Write("Salário: ");
B.Salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

decimal salarioMedio = (A.Salario + B.Salario) / 2;

Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));