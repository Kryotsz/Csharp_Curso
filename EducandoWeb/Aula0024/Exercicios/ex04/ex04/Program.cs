using System.Globalization;

int numeroFuncionario = int.Parse(Console.ReadLine());
int horasTrabalhadas =  int.Parse(Console.ReadLine());
decimal valorHora = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

decimal valorFinal = valorHora * horasTrabalhadas;

Console.WriteLine("NUMBER = " + numeroFuncionario);
Console.WriteLine("SALARY = U$ " + valorFinal.ToString("F2", CultureInfo.InvariantCulture));