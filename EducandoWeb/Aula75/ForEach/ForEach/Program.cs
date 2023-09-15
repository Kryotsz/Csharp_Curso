string[] nomes = new string[] { "Maria", "Alex", "Bob" };

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);
}

Console.WriteLine("------");

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}