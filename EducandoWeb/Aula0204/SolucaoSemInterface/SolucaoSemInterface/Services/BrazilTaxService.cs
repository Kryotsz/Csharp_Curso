namespace SolucaoSemInterface.Services
{
    // classe sem propriedades nem atributos
    // apenas um método
    internal class BrazilTaxService
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
