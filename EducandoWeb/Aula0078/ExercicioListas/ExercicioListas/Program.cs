using ExercicioListas;
using System.Globalization;

Console.Write("How many employees will be registered? ");
int n = int.Parse(Console.ReadLine());
int id;

List<Employee> listEmployee = new List<Employee>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Employee #{i}");
    Console.Write("Id: ");
    id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine();

    Employee employee = new Employee(id, name, salary);
    listEmployee.Add(employee);
}

Console.Write("Enter the employee id that will have salary increase: ");
id = int.Parse(Console.ReadLine());

Employee e = listEmployee.Find(x => x.Id == id);

if (e != null)
{
    Console.Write("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    e.IncreaseSalary(percentage);
}
else
{
    Console.WriteLine("This id does not exist!");
}


Console.WriteLine();
Console.WriteLine("Updated list of employees:");
foreach (Employee obj in listEmployee)
{
    Console.WriteLine(obj);
}