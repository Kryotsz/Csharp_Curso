using System.Globalization;

namespace GenericsRestricoes.Entities
{
    // classe Product também tem que implementar o IComparable
    internal class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        // implementa o método do IComparable
        public int CompareTo(object? obj)
        {
            // se o objeto recebido não for um Product
            if (!(obj is Product))
            {
                // lança um erro
                throw new ArgumentException("Comparing error: argument is not a Product");
            }

            // obj as Product é um Downcasting
            Product other = obj as Product;

            // compara o preço deste produto, com o preço do produto recebido por parâmetro
            return Price.CompareTo(other.Price);
        }
    }
}
