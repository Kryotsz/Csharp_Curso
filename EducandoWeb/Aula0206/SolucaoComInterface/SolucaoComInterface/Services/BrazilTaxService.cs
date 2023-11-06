namespace SolucaoComInterface.Services
{
    // classe BrazilTaxService está implementando a operação prevista na interface ITaxService
    // Realização de Interface
    // NÃO É HERANÇA
    internal class BrazilTaxService : ITaxService
    {
        // método que calcula imposto
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
