using ExercicioFixacaoExceptions.Entities;
using ExercicioFixacaoExceptions.Entities.Exceptions;
using System.Globalization;

try
{
    // entrada de dados da conta
    Console.WriteLine("Enter account data");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string name = Console.ReadLine();
    Console.Write("Initial balance: ");
    double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Withdraw limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    // cria uma nova conta com os dados fornecidos
    Account account = new Account(number, name, initialBalance, withdrawLimit);
    // entrada de dados da quantia a ser sacada
    Console.WriteLine();
    Console.Write("Enter amount for withdraw: ");
    double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    // chama o método de saque e passa a quantia como parâmetro
    account.Withdraw(amount);

    // imprime na tela o novo valor do saldo
    Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
}
catch (DomainException e)
{
    // imprime o erro de saque na tela
    Console.WriteLine($"Withdraw error: {e.Message}");
}
