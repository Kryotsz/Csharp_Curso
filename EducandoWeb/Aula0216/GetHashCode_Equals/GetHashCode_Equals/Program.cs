using GetHashCode_Equals.Entities;

//string a = "Maria";
//string b = "Alex";

//// em uma fonte de dados grande
//// fazer uma busca utilizando HashCode, pois se gerar números diferentes, com certeza o objeto é diferente
//// e ao gerar um número igual, daí sim confirmar com o Equals para ter certeza de que os objetos são iguais (pois o HashCode pode gerar o mesmo número por coincidência)

//Console.WriteLine(a.GetHashCode());
//Console.WriteLine(b.GetHashCode());

//Console.WriteLine(a.Equals(b));

Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };

// o Equals vai comparar o conteúdo Email, como é igual, vai dar verdadeiro
Console.WriteLine(a.Equals(b));
// o "==" compara a referência do ponteiro de memória do objeto, como são objetos diferentes, ele sempre vai dar falso
Console.WriteLine(a == b);
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());