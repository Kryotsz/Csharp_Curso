using ExemploDelegateFunc.Entities;

namespace ExemploDelegateFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // no Select da pra passar a referência da função diretamente
            // o Select retorna um IEnumerable, então esse retorno tem que ser convertido pra lista utilizando o ToList
            //List<string> result = list.Select(NameToUpper).ToList();

            // da pra utilizar expressão lambda também
            //Func<Product, string> func = p => p.Name.ToUpper();

            // assim como também da pra passar a expressão lambda diretamente no Select (inline)
            //List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            // Delegate Func representa um método que recebe zero ou mais argumentos, e retorna um valor
            Func<Product, string> func = NameToUpper;

            // no Select também da pra passar a referência pra função usando o delegate
            List<string> result = list.Select(func).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static string NameToUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}