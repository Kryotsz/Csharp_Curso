using System;

namespace ExercicioFixacaoInterfaces.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        // constantes privadas para somente ser utilizadas nos cálculos
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        // método para calcular juros
        public double Interest(double amount, int installmentQuantity)
        {
            return amount * MonthlyInterest * installmentQuantity;
        }

        // método para calcular a taxa de pagamento
        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
