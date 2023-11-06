using ExercicioEnumEComposicao.Entities;
using ExercicioEnumEComposicao.Enums;
using System.Globalization;

// entrada de dados do cliente
Console.WriteLine("Enter client data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime date =  DateTime.Parse(Console.ReadLine());

// entrada de dados do pedido
// status do pedido
Console.WriteLine();
Console.WriteLine("Enter order data");
Console.Write("Status: ");
OrderStatus status =  Enum.Parse<OrderStatus>(Console.ReadLine());

// instancia um novo cliente e um novo pedido com os dados informados
Client client = new Client(name, email, date);
Order order = new Order(DateTime.UtcNow, status, client);

// entrada do número de produtos do pedido
Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    // entrada de dados do produto
    Console.WriteLine();
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product name: ");
    string pName = Console.ReadLine();
    Console.Write("Product price: ");
    double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    // instancia um novo produto e um novo item do pedido com os dados informados
    Product product = new Product(pName, pPrice);
    OrderItem orderItem = new OrderItem(quantity, pPrice, product);
    
    // adiciona o item do pedido no pedido
    order.AddItem(orderItem);
}

Console.WriteLine();
Console.WriteLine("ORDER SUMMARY:");
Console.WriteLine(order);