string original = "abcde FGHIJ ABC abc DEFG     ";

string s1 = original.ToUpper();
string s2 = original.ToLower();
string s3 = original.Trim();
int n1 = original.IndexOf("bc");
int n2 = original.LastIndexOf("bc");

Console.WriteLine($"Original: -{original}-");
Console.WriteLine($"ToUpper: -{s1}-");
Console.WriteLine($"ToLower: -{s2}-");
Console.WriteLine($"Trim: -{s3}-");
Console.WriteLine($"IndexOf('bc'): {n1}");
Console.WriteLine($"LastIndexOf('bc'): {n2}");