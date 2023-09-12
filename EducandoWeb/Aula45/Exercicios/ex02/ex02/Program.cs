using ex02;
using System.Globalization;

Funcionario funcionario = new Funcionario();

Console.Write("Nome: ");
funcionario.Nome = Console.ReadLine();
Console.Write("Salário bruto: ");
funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Imposto: ");
funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

funcionario.SalarioLiquido();

Console.WriteLine();
Console.WriteLine("Funcionário: " + funcionario);

Console.WriteLine();
Console.Write("Digite a porcentagem para aumentar o salário: ");
double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

funcionario.AumentarSalario(porcentagem);

Console.WriteLine("Dados atualizados: " + funcionario);