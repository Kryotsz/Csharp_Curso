namespace ExercicioFixacaoExceptions.Entities.Exceptions
{
    // sub classe DomainException herda da super classe ApplicationException
    internal class DomainException : ApplicationException
    {
        // construtor que recebe como parâmetro a mensagem de erro
        public DomainException(string error) : base(error) { }
    }
}
