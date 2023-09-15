double? x = null;
double? y = 10;

// se 'x' não for nulo, passa o valor de 'x' pro 'a', se 'x' for nulo, passa o valor a direita (5) pro 'a'
double a = x ?? 5;
double b = y ?? 5;

Console.WriteLine(a);
Console.WriteLine(b);