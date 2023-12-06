using UtilizandoSortComparison.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("TV", 900.00));
list.Add(new Product("Notebook", 1200.00));
list.Add(new Product("Tablet", 450.00));

// só funciona se o tipo da lista implementa a interface IComparable
//list.Sort();

// utilizando função lambda (função anônima)
//Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

// passou a referência para a função, isso se chama delegate
// dá pra passar direto a função lambda como parâmetro (expressão lambda inline)
list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

foreach (Product p in list)
{
    Console.WriteLine(p);
}

// dá pra usar uma função lambda ao invés desse método
//static int CompareProducts(Product p1, Product p2)
//{
//    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
//}