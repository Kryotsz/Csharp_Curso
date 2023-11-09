using ExercicioFixacaoInterfaces.Entities;

namespace ExercicioFixacaoInterfaces.Services
{
    internal class ContractService
    {
        // atributo privado
        private IOnlinePaymentService _onlinePaymentService;

        // construtor
        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        // método
        public void ProcessContract(Contract contract, int installmentQuantity)
        {
            // divide o valor pela quantidade de parcelas
            double basicQuota = contract.TotalValue / installmentQuantity;
            for (int i = 1; i <= installmentQuantity; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                // valor com juros
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                // valor com juros e taxa (valor final)
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                // chama o método para adicionar uma nova parcela no contrato, passando a data e os dados da parcela atual
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
