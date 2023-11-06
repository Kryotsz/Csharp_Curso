using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            // declara variavel conta do tipo Conta (classe)
            Conta conta;

            // entrada do número da conta
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            // entrada do titular da conta
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            // entrada da decisão de ter um depósito inicial ou não
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());

            // verifica a resposta da decisão de depósito inicial
            if (resposta.ToString().ToLower().Trim() == "s")
            {
                // entrada do valor do depósito inicial
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                // utiliza o construtor de 3 parâmetros
                conta = new Conta(numero, titular, depositoInicial);
            }
            else
            {
                // utiliza o construtor de 2 parâmetros
                conta = new Conta(numero, titular);
            }

            // escreve na tela os dados da conta
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            // entrada do valor de depósito
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // chama o método 'Deposito' e passa o valor digitado como parâmetro
            conta.Deposito(valor);

            // escreve na tela os dados atualizados da conta
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            // entrada do valor de saque
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // chama o método 'Saque' e passa o valor digitado como parâmetro
            conta.Saque(valor);

            // escreve na tela os dados atualizados da conta
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}