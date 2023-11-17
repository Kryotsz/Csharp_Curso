using GenericsRestricoes.Entities;
using GenericsRestricoes.Services;
using System.Globalization;

// instancia uma lista de produtos vazia
List<Product> list = new List<Product>();

// entrada de quantos valores serão lidos
Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    // le os dados do produto e separa pela virgula
    string[] vect = Console.ReadLine().Split(',');
    string name = vect[0];
    double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
    // adiciona o produto na lista, instanciando com o nome e preço lidos
    list.Add(new Product(name, price));
}

// instancia um novo CalculationService
CalculationService calculationService = new CalculationService();

// cria a variável max para receber o maior valor da lista
Product max = calculationService.Max(list);

// imprime na tela o maior valor da lista
Console.WriteLine("Max: ");
Console.WriteLine(max);