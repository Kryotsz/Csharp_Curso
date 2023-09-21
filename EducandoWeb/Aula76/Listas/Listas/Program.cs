// cria lista do tipo string e instancia ela
List<string> list = new List<string>();
// da pra criar a lista, instanciar e também já popular
List<string> list2 = new List<string>() { "Maria", "Alex" };

// Add = adiciona o item na próxima posição disponível da lista
list.Add("Maria");
list.Add("Alex");
list.Add("Bob");
list.Add("Anna");
list.Add("José");
list.Add("Rodrigo");
list.Add("Leandro");
list.Add("Tony");
// Insert = adiciona o item na posição(index) desejada
list.Insert(2, "Marco");

// imprime na tela os itens da list
foreach (string nome in list)
{
    Console.WriteLine(nome);
}

// conta quantos itens tem na lista
Console.WriteLine();
Console.WriteLine("List Count: " + list.Count);

// Find = retorna a primeira ocorrência
// Expressão lambda = retorna 'x' quando 'x' na posiçao '0' for igual a 'A'
string s1 = list.Find(x => x[0] == 'A');
Console.WriteLine();
Console.WriteLine("First 'A': " + s1);

// FindLast = retorna a última ocorrência
string s2 = list.FindLast(x => x[0] == 'A');
Console.WriteLine("Last 'A': " + s2);

// FindIndex = retorna o index(posição) da primeira ocorrência
int pos1 = list.FindIndex(x => x[0] == 'A');
Console.WriteLine("First position 'A': " + pos1);

// FindLastIndex = retorna o index(posição) da última ocorrência
int pos2 = list.FindLastIndex(x => x[0] == 'A');
Console.WriteLine("Last position 'A': " + pos2);

Console.WriteLine("-----------------------");

// FindAll = retorna todas as ocorrências
List<string> list3 = list.FindAll(x => x.Length >= 5);
// imprime na tela os itens da list2
foreach (string obj in list3)
{
    Console.WriteLine(obj);
}

Console.WriteLine("-----------------------");

// Remove = remove o item desejado da lista
list.Remove("Alex");

foreach (string nome in list)
{
    Console.WriteLine(nome);
}

Console.WriteLine("-----------------------");

// RemoveAll = remove todas as ocorrências
list.RemoveAll(x => x[0] == 'M');

foreach (string nome in list)
{
    Console.WriteLine(nome);
}

Console.WriteLine("-----------------------");

// RemoveAt = remove o item da posiçao(index) desejada
list.RemoveAt(0);

foreach (string nome in list)
{
    Console.WriteLine(nome);
}

Console.WriteLine("-----------------------");

// RemoveRange = a partir da posição x, remove x elementos
list.RemoveRange(2, 2);

foreach (string nome in list)
{
    Console.WriteLine(nome);
}