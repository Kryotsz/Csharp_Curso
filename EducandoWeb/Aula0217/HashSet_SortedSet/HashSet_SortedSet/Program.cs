// Conjuntos de elementos
// não admite repetições
// elementos não possuem posição
// acesso, inserção e remoção de elementos são rápidos
// operações de intersecção, união e diferença

// HashSet
// armazenamento em tabela hash
// extremamente rápido: inserção, remoção e busca (ordem 1 (apenas 1 passo))
// ordem dos elementos não é garantida

// SortedSet
// armazenamento em árvore
// rápido: inserção, remoção e busca (ordem logarítmica de N na base 2)
// os elementos são armazenados ordenadamente conforme implementação IComparer<T>

// se a ordem não for importante, utiliza-se o HashSet pois ele é mais rápido que o SortedSet

HashSet<string> set = new HashSet<string>();

set.Add("TV");
set.Add("Notebook");
set.Add("Tablet");

Console.WriteLine(set.Contains("Computer"));

// para percorrer o conjunto, tem que utilizar foreach (for não pode ser utilizado, pois o conjunto não tem posições)
foreach (string p in set)
{
    Console.WriteLine(p);
}

// --------------------------------------------------------------------------------------------------------------------------
Console.WriteLine("-----------");
// --------------------------------------------------------------------------------------------------------------------------

// mesmo com os elementos desordenados, o SortedSet ordena eles
SortedSet<int> a = new SortedSet<int>() { 10, 0, 2, 4, 5, 6, 8 };
SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

// union (une ambos os conjuntos, o novo conjunto terá todos os elementos de ambos, não repetindo nenhum item)
// instancia um novo conjunto C e insere nele todos os elementos do conjunto A (utilizando um construtor que o SortedSet ja tem)
SortedSet<int> c = new SortedSet<int>(a);
// vai inserir todos os elementos do B para dentro do C (mas apenas os que não existem ainda, não irá adicionar itens repetidos)
c.UnionWith(b);
PrintCollection(c);

// intersection (contém todos os elementos em comum de ambos os conjuntos)
// conjunto D terá todos elementos do conjunto A
SortedSet<int> d = new SortedSet<int>(a);
// faz a intersecção do D com o B, portanto, agora o D vai ter somente os elementos que existiam em ambos os conjuntos
d.IntersectWith(b);
PrintCollection(d);

// difference (contém os elementos do primeiro conjunto que NÃO existem no segundo conjunto)
// conjunto E terá todos elementos do conjunto A
SortedSet<int> e = new SortedSet<int>(a);
// faz a diferença entre conjunto E e conjunto B, portanto agora o E vai ter somente os elementos que NÃO existem no B
e.ExceptWith(b);
PrintCollection(e);

// método PrintColeection do tipo T que recebe por parâmetro o objeto collection também do tipo T que implementa o IEnumerable
static void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (T obj in collection)
    {
        Console.Write(obj + " ");
    }
    Console.WriteLine();
}