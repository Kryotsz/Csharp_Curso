// Dictionary
// Armazenamento em tabela hash
// Extremamente rápido: inserção, remoção e busca O(1) (ordem de 1)

// SortedDictionary
// Armazenamento em árvore
// Rápido: inserção, remoção e busca (ordem logarítmica)
// Elementos armazenados em ordem, conforme implementação do IComparer<T>

Dictionary<string, string> cookies = new Dictionary<string, string>();

cookies["user"] = "maria";
cookies["email"] = "maria@gmail.com";
cookies["phone"] = "99712234";
// só pode ter 1 valor por chave, não pode ter chave repetida, portanto, irá sobreescrever o phone
cookies["phone"] = "83737388";

Console.WriteLine(cookies["email"]);

cookies.Remove("email");

if (cookies.ContainsKey("email"))
{
    Console.WriteLine(cookies["email"]);
}
else
{
    Console.WriteLine("There is no 'email' key");
}

Console.WriteLine($"Size: {cookies.Count}");

Console.WriteLine("ALL COOKIES:");
// no lugar de "KeyValuePair<string, string>", dá pra usar "var item"
//foreach (var item in cookies)
//{
//    Console.WriteLine(item.Key + ": " + item.Value);
//}
foreach (KeyValuePair<string, string> item in cookies)
{
    Console.WriteLine(item.Key + ": " + item.Value);
}