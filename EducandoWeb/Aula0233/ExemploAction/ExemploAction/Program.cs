using ExemploAction.Entities;

class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        list.Add(new Product("Tv", 900.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Tablet", 350.50));
        list.Add(new Product("HD Case", 80.90));

        // o delegate action representa um método void que recebe zero ou mais argumentos
        Action<Product> act = UpdatePrice;

        // da pra fazer dessa forma, utilizando expressão lambda
        //Action<Product> act = p => { p.Price += p.Price * 0.1; };

        // da pra fazer direto assim também
        //list.ForEach(p => { p.Price += p.Price * 0.1; });

        list.ForEach(act);
        foreach (Product p in list)
        {
            Console.WriteLine(p);
        }
    }

    static void UpdatePrice(Product p)
    {
        p.Price += p.Price * 0.1;
    }
}