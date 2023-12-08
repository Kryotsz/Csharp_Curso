internal class Program
{
    static void Main(string[] args)
    {
        // Specify the data source
        int[] numbers = new int[] { 2, 3, 4, 5 };

        // Define the query expression
        // vai gerar uma nova coleção, somente com os itens que atenderem o predicado
        // retorna um IEnumerable
        var result = numbers
            .Where(x => x % 2 == 0)
            .Select(x => x * 10);
        // nesse exemplo, recebe x, tal que o resto da divisão de x por 2 é igual a 0
        // e recebe x e faz x * 10
        // ou seja, pega todos os elementos pares da fonte de dados e multiplica por 10

        // Execute the query
        foreach (int x in result)
        {
            Console.WriteLine(x);
        }
    }
}
