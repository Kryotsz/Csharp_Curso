using ExercicioFixacaoMetodosAbstratos.Entities;
using System.Globalization;

List<TaxPayer> listTaxPayers = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Tax payer #{i} data:");
    Console.Write("Individual or company (i/c)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (ch == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpend = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        listTaxPayers.Add(new Individual(name, income, healthExpend));
    }
    else
    {
        Console.Write("Number of employees: ");
        int emp = int.Parse(Console.ReadLine());
        listTaxPayers.Add(new Company(name, income, emp));
    }
}

double sum = 0;

Console.WriteLine();
Console.WriteLine("TAXES PAID:");
foreach (TaxPayer t in listTaxPayers)
{
    Console.WriteLine(t);
    sum += t.Tax();
}

Console.WriteLine();
Console.WriteLine("TOTAL TAXES: " + sum.ToString("F2", CultureInfo.InvariantCulture));