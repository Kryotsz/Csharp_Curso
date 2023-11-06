namespace ExercicioExemploHerancaPolimorfismo.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionlCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionlCharge;
        }

        public override double Payment()
        {
            return Hours * ValuePerHour + AdditionalCharge * 1.1;
        }
    }
}
