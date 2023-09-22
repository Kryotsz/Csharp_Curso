// frase original
string original = "abcde FGHIJ ABC abc DEFG     ";

// transforma a frase em maiúsculo
string s1 = original.ToUpper();
// transforma a frase em minúsculo
string s2 = original.ToLower();
// corta os espaços em branco antes e depois da frase
string s3 = original.Trim();

// retorna a posição do primeiro "bc" encontrado na frase
int n1 = original.IndexOf("bc");
// retorna a posição do último "bc" encontrado na frase
int n2 = original.LastIndexOf("bc");

// retorna a frase a partir da 3 posição(caractere)
string s4 = original.Substring(3);
// retorna os 5 caracteres a partir da 3 posição(caractere)
string s5 = original.Substring(3, 5);
// forma simplificada do Substring
//string s4 = original[3..];

// substitui todas as ocorrências do 'a' por 'x'
string s6 = original.Replace('a', 'x');
// substitui todas as ocorrências do "abc" por "xy"
string s7 = original.Replace("abc", "xy");

// verifica se a string é nula ou vazia
bool b1 = String.IsNullOrEmpty(original);
bool b2 = String.IsNullOrWhiteSpace(original);

Console.WriteLine($"Original: -{original}-");
Console.WriteLine($"ToUpper: -{s1}-");
Console.WriteLine($"ToLower: -{s2}-");
Console.WriteLine($"Trim: -{s3}-");
Console.WriteLine($"IndexOf('bc'): {n1}");
Console.WriteLine($"LastIndexOf('bc'): {n2}");
Console.WriteLine($"Substring(3): -{s4}-");
Console.WriteLine($"Substring(3, 5): -{s5}-");
Console.WriteLine($"Replace('a', 'x'): -{s6}-");
Console.WriteLine($"Replace('abc', 'xy'): -{s7}-");
Console.WriteLine($"IsNullOrEmpty: {b1}");
Console.WriteLine($"IsNullOrWhiteSpace: {b2}");