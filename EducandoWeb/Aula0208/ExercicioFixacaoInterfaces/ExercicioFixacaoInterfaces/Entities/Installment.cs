using System.Globalization;

namespace ExercicioFixacaoInterfaces.Entities
{
    internal class Installment
    {
        // propriedades da parcela
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        // construtor
        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
