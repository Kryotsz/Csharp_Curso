using System.Globalization;

namespace ArquivosFixacao.Entities
{
    internal class Product
    {
        // propriedades do produto
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        // construtor padrão do produto
        public Product() { }

        // construtor de 3 parâmetros do produto
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // método que retorna o preço total do produto
        private double TotalPrice()
        {
            return Price * Quantity;
        }

        // método que sobreescreve o ToString, para escrever o produto em forma de csv, separando os dados por vírgula
        public override string ToString()
        {
            return Name
                    + ","
                    + TotalPrice().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
