using ExercicioResolvidoLINQ.Entities;
using System.Globalization;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter full file path: ");
        string path = Console.ReadLine();

        List<Product> products = new List<Product>();

        using (StreamReader sr = File.OpenText(path))
        {
            while (!sr.EndOfStream)
            {
                string[] fields = sr.ReadLine().Split(',');
                string name = fields[0];
                double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                products.Add(new Product(name, price));
            }
        }

        var avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();

        Console.WriteLine();

        Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

        //var names =
        //    from p in products
        //    where p.Price < avg
        //    orderby p.Name descending
        //    select p.Name;

        var names = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}