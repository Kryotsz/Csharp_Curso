using ExercicioFixacaoExceptions.Entities.Exceptions;

namespace ExercicioFixacaoExceptions.Entities
{
    internal class Account
    {
        // propriedades da conta
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        // construtor padrão
        public Account() { }

        // construtor de 3 parâmetros
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        // método de depósito
        public void Deposit(double amount)
        {
            // adiciona a quantia a ser depositada no saldo da conta
            Balance += amount;
        }

        // método de saque
        public void Withdraw(double amount)
        {
            // se a quantia a ser sacada for maior que o saldo da conta
            if (amount > Balance)
            {
                // lança um novo erro e passa a mensagem por parâmetro
                throw new DomainException("Not enough balance");
            }
            // se a quantia a ser sacada for maior que o limite de saque
            if (amount > WithdrawLimit)
            {
                // lança um novo erro e passa a mensagem por parâmetro
                throw new DomainException("The amount exceed withdraw limit");
            }
            // se não tiver nenhum erro, ele retira a quantia a ser sacada do saldo da conta
            Balance -= amount;
        }
    }
}
