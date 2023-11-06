using SolucaoComInterface.Entities;
using SolucaoComInterface.Services;
using System.Globalization;

Console.WriteLine("Enter rental data");
Console.Write("Car model: ");
string model = Console.ReadLine();
Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.Write("Return (dd/MM/yyyy HH:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Enter price per hour: ");
double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter price per day: ");
double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// a model é o parâmetro do veículo, não do CarRental
// o parâmetro do CarRental é um veículo
// portanto deve ser instanciado um novo veículo, passando model como parâmetro, e então o veículo será passado para o CarRental
CarRental carRental = new CarRental(start, finish, new Vehicle(model));

// RentalService exige um ITaxService como parâmetro
// o BrazilTaxService é um subtipo de ITaxService então pode ser utilizado
RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

rentalService.ProcessInvoice(carRental);

Console.WriteLine();
Console.WriteLine("INVOICE:");
Console.WriteLine(carRental.Invoice);