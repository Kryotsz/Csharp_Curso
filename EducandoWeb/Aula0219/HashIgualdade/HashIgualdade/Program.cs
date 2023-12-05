using HashIgualdade.Entities;

//HashSet<string> set = new HashSet<string>();

//set.Add("Maria");
//set.Add("Alex");

//// o método Contains vai primeiro vai usar o GetHashCode no elemento passado por parâmetro (Maria)
//// depois vai verificar se no conjunto existe algum item com o mesmo HashCode
//// se existir, ele então utiliza o Equals para confirmar se é o mesmo elemento ou não
//Console.WriteLine(set.Contains("Maria"));

HashSet<Product> a = new HashSet<Product>();
a.Add(new Product("TV", 900.00));
a.Add(new Product("Notebook", 1200.00));

HashSet<Point> b = new HashSet<Point>();
b.Add(new Point(3, 4));
b.Add(new Point(5, 10));

Product prod = new Product("Notebook", 1200.00);
// como não tem GetHashCode e Equals implementado, o Contains compara a referência de memória dos objetos (são diferentes mesmo tendo o mesmo conteúdo)
// quando tem ambos implementados, seguirá a regra que foi escrita no código (nesse caso, vai comparar nome e preço e dizer que é igual)
Console.WriteLine(a.Contains(prod));

Point p = new Point(5, 10);
// quando o tipo é Struct, ele compara por conteúdo e não por referência, portanto, dirá que são iguais
Console.WriteLine(b.Contains(p));