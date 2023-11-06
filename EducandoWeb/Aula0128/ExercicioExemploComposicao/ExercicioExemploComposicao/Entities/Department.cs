namespace ExercicioExemploComposicao.Entities
{
    internal class Department
    {
        // propriedades do departamento
        public string Name { get; set; }

        // construtor padrão
        public Department() { }

        // construtor de 1 parâmetro
        public Department(string name)
        {
            Name = name;
        }
    }
}
