using LINQLambda.Entities;

internal class Program
{
    // função auxiliar pra imprimir no console
    // recebe uma mensagem e uma coleção
    static void Print<T>(string message, IEnumerable<T> collection)
    {
        // imprime a mensagem
        Console.WriteLine(message);
        // percorre a coleção
        foreach (T obj in collection)
        {
            // e imprime cada objeto
            Console.WriteLine(obj);
        }
        // imprime uma linha em branco
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
        Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
        Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

        List<Product> products = new List<Product>()
        {
            new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
            new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
            new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
            new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
            new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
            new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
            new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
            new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
            new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
            new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
            new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
        };

        // retorna todos os produtos que são tier 1 e preço menor que 900
        var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
        Print("TIER 1 AND PRICE < 900:", r1);

        // utilizando só o Where, iria retornar o objeto inteiro, como queremos somente o nome, utilizamos o Select (recebe o objeto p e retorna só o nome)
        var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
        Print("NAMES OF PRODUCTS FROM TOOLS", r2);

        // utilizando objeto anônimo para trazer nome, preço e nome da categoria (esse último tem que utilizar um ALIAS, um apelido, pois o compilador interpreta que p.Name e p.Category.Name tem o mesmo nome)
        var r3 = products.Where(p => p.Name.StartsWith('C')).Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
        Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

        // retorna os produtos de categoria 1 e ordena de forma crescente por preço, e então, caso tenham o mesmo preço, ordena por nome
        var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
        Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

        // utilizando o resultado r4, pula os 2 primeiros e então pega 4 elementos
        var r5 = r4.Skip(2).Take(4);
        Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

        // First() retorna o primeiro valor da coleção
        var r6 = products.FirstOrDefault();
        Console.WriteLine($"First or default test1: {r6}");

        // filtra apenas os elementos com preço maior que 3000 e depois pega o primeiro utilizando o First() (como não tem nenhum, vai retornar uma exceção)
        // uma alternativa para não aparecer a exceção, é utilizar o FirstOrDefault() ao invés do First()
        var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
        Console.WriteLine($"First or default test2: {r7}");

        Console.WriteLine();

        // uma busca por Id só pode retornar 1 ou 0 elementos
        // sem o SingleOrDefault, ele retorna uma coleção, mesmo que só tenha 1 elemento
        // com o SingleOrDefault, ele retorna um único objeto Product
        var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
        Console.WriteLine($"Single or default teste1: {r8}");

        // caso não tenha nenhum elemento com esse Id ele retorna null
        var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
        Console.WriteLine($"Single or default teste1: {r9}");

        Console.WriteLine();

        // pega o maior elemento da coleção com base no preço
        // se não tiver parâmetros, a classe tem que implementar o IComparable pra dar um critério de comparação
        var r10 = products.Max(p => p.Price);
        Console.WriteLine($"Max price: {r10}");

        // pega o menor elemento da coleção com base no preço
        var r11 = products.Min(p => p.Price);
        Console.WriteLine($"Min price: {r11}");

        // retorna a soma dos preços dos elementos de categoria 1
        var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
        Console.WriteLine($"Category 1 Sum prices: {r12}");

        // retorna a média dos preços dos elementos de categoria 1
        // como o calculo de média envolve divisão, se o filtro retornar uma coleção vazia, o calculo dará erro
        var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
        Console.WriteLine($"Category 1 Average prices: {r13}");

        // filtra por categoria 5, seleciona somente os preços, e se for vazio atribui o resultado 0.0
        var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
        Console.WriteLine($"Category 5 Average prices: {r14}");

        // montar uma operação agregada personalizada (mapReduce)
        // em C# se utiliza o Agreggate pra isso
        // recebe x e y e retorna a soma entre eles
        // pra evitar erros caso a consulta seja vazia, utiliza-se um valor inicial padrão
        var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
        Console.WriteLine($"Category 1 Aggregate sum: {r15}");

        Console.WriteLine("-----------------------------------------------------------------------");

        var r16 = products.GroupBy(p => p.Category);
        // percorre as categorias agrupadas
        foreach (IGrouping<Category, Product> group in r16)
        {
            // imprime o nome da categoria
            Console.WriteLine($"Category {group.Key.Name}:");
            // percorre os produtos dessa categoria
            foreach (Product p in group)
            {
                // e imprime os produtos na tela
                Console.WriteLine(p);
            }
            Console.WriteLine();
        }
    }
}
