using ExercicioFixacaoInterfaces.Entities;
using ExercicioFixacaoInterfaces.Services;
using System.Globalization;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Contract value: ");
double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter number of installments: ");
int installmentQuantity =  int.Parse(Console.ReadLine());

// instancia um novo contrato com os itens digitados
Contract contract = new Contract(number, date, value);

ContractService contractService = new ContractService(new PaypalService());
contractService.ProcessContract(contract, installmentQuantity);

// imprime na tela todas as parcelas
Console.WriteLine();
Console.WriteLine("Installments:");
foreach (Installment i in contract.Installments)
{
    Console.WriteLine(i);
}