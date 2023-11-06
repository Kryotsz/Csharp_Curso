using ExercicioExemploComposicao.Entities.Enums;

namespace ExercicioExemploComposicao.Entities
{
    internal class Worker
    {
        // propriedades de Worker
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        // lista de contratos, já instanciada
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        // construtor padrão
        public Worker() { }
        // construtor com todos os parâmetros (exceto a lista)
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        // método que adiciona contratos na lista
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        // método que remove contratos da lista
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        // método que retorna o salário total que o Worker irá receber
        public double Income(int year, int month)
        {
            // inicia a variável sum, que já começa com o salário base
            double sum = BaseSalary;

            // loop que percorre todos os contratos na lista de contratos
            foreach (HourContract contract in Contracts)
            {
                // se o ano e o mês do contrato forem iguais ao mês e ano digitados pelo usuário
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    // variável soma o valor total do contrato
                    sum += contract.TotalValue();
                }
            }
            // retorna a soma
            return sum;
        }
    }
}
