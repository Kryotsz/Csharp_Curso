namespace Heranca.Entities
{
    internal class Account
    {
        // private não deixa ser alterado fora dessa classe
        public int Number { get; private set; }
        public string Holder { get; private set; }
        // protected permite que a subclasse altere, mas não o programa principal
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
