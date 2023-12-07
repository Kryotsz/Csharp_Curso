using ExemploPredicate.Entities;

class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        list.Add(new Product("Tv", 900.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Tablet", 350.50));
        list.Add(new Product("HD Case", 80.90));

        // utilizando função lambda (função anônima)
        //list.RemoveAll(p => p.Price >=100.0);
        //foreach (Product p in list)
        //{
        //    Console.WriteLine(p);
        //}

        // utilizando Predicate (Predicate é um delegate, ou seja, referência para uma função)
        // Predicate representa um método que recebe um objeto do tipo T e retorna um valor booleano
        list.RemoveAll(ProductTest);
        foreach (Product p in list)
        {
            Console.WriteLine(p);
        }
    }

    public static bool ProductTest(Product p)
    {
        return p.Price >= 100.0;
    }
}
