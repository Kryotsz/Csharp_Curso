using ExercicioFixacaoLINQ.Entities;
using System.Globalization;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter full file path: ");
        string path = Console.ReadLine();

        List<Employee> employees = new List<Employee>();

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] data = sr.ReadLine().Split(',');
                    string name = data[0];
                    string email = data[1];
                    double salary = double.Parse(data[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double salaryComparison = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var emails = employees.Where(e => e.Salary > salaryComparison).OrderBy(e => e.Email).Select(e => e.Email);

            Console.WriteLine();
            Console.WriteLine("Email of people whose salary is more than " + salaryComparison.ToString("F2", CultureInfo.InvariantCulture) + ":");
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }

            var sum = employees.Where(e => e.Name.StartsWith('M')).Sum(e => e.Salary);

            Console.WriteLine();
            Console.Write("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred!");
            Console.WriteLine(e.Message);
        }

        
    }
}
