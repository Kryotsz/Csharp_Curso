namespace ExercicioFixacaoInterfaces.Entities
{
    internal class Contract
    {
        // propriedades do contrato
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        // lista de parcelas
        public List<Installment> Installments { get; set; }

        // construtor
        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        // método para adicionar parcelas
        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
