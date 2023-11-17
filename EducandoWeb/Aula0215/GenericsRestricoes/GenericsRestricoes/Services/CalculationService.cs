using System.ComponentModel.DataAnnotations;

namespace GenericsRestricoes.Services
{
    // classe normal porém com métodos genéricos
    internal class CalculationService
    {
        // metódo do tipo T
        // o tipo T tem que ser um tipo comparável, portanto, ele precisa implementar a interface IComparable
        public T Max<T>(List<T> list) where T : IComparable
        {
            // verifica se a lista está vazia
            if (list.Count == 0)
            {
                // lança uma exceção
                throw new ArgumentException("The list cannot be empty");
            }

            // define o primeiro item da lista como o maior
            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                // compara os itens da lista com o maior item utilizando o método CompareTo da interface IComparable
                // retorna -1 caso for menor, 0 caso for igual e 1 caso for maior
                if (list[i].CompareTo(max) > 0)
                {
                    // substitui o maior 
                    max = list[i];
                }
            }
            // retorna o maior valor
            return max;
        }
    }
}
