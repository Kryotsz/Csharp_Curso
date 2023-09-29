namespace ExercicioExemploComposicao.Entities
{
    internal class HourContract
    {
        // propriedades do contrato
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        // construtor padrão
        public HourContract() { }
        // construtor de 3 parâmetros
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        // método que calcula o valor total do contrato
        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
