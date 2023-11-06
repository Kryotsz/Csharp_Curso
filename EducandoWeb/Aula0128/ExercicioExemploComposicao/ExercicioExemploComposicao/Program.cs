using ExercicioExemploComposicao.Entities;
using ExercicioExemploComposicao.Entities.Enums;
using System.Globalization;
// input do nome do departamento
Console.Write("Enter department's name: ");
string deptName = Console.ReadLine();

// input dos dados do trabalhador
Console.WriteLine();
Console.WriteLine("Enter worker data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// instancia o departamento, passando o valor digitado
Department dept = new Department(deptName);
// instancia o trabalhador passando todos os dados digitados, inclusive o departamento já instanciado
Worker worker = new Worker(name, level, baseSalary, dept);

// input do número de contratos
Console.WriteLine();
Console.Write("How many contracts to this worker? ");
int n = int.Parse(Console.ReadLine());

// loop para input dos dados do contrato
for (int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Enter #{i} contract data:");
    Console.Write("Date (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duration (hours): ");
    int hours = int.Parse(Console.ReadLine());
    // instancia um novo contrato com os dados digitados
    HourContract contract = new HourContract(date, valuePerHour, hours);
    // chama o método para adicionar o contrato na lista de contratos do trabalhador
    worker.AddContract(contract);
}

// input do mês e ano pra imprimir na tela o valor recebido pelo trabalhador
Console.WriteLine();
Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string monthAndYear = Console.ReadLine();
// começa da posição 0 e pega os 2 primeiros caracteres
int month = int.Parse(monthAndYear.Substring(0, 2));
// começa da posição 3 e pega todos os caracteres a partir dali
int year = int.Parse(monthAndYear.Substring(3));
// imprime na tela os dados desejados
Console.WriteLine($"Name: {worker.Name}");
Console.WriteLine($"Department: {worker.Department.Name}");
Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));