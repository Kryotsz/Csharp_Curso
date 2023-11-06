using SolucaoSemInterface.Entities;

namespace SolucaoSemInterface.Services
{
    internal class RentalService
    {
        // propriedades
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        // atributo privado, por isso o underline no início do nome
        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        // construtor
        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            // duração do aluguel do carro
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment;
            if (duration.TotalHours <= 12.0)
            {
                // preço por hora vezes a duração em horas, arredondado pra cima
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                // preço por dia vezes a duração em dias, arredondado pra cima
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            // atributo chama o método Tax da classe BrazilTaxService, passando o basicPayment como parâmetro
            // retorna o valor calculado do imposto pra variável tax
            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
