//Nullable<double> x = null;

// forma simplificada de declarar um valor nullable
double? x = null;
double? y = 10.0;

Console.WriteLine(x.GetValueOrDefault());
Console.WriteLine(y.GetValueOrDefault());

Console.WriteLine(x.HasValue);
Console.WriteLine(y.HasValue);

if (x.HasValue)
{
    Console.WriteLine(x.Value);
}
else
{
    Console.WriteLine("X is null");
}

if (y.HasValue)
{
    Console.WriteLine(y.Value);
}
else
{
    Console.WriteLine("Y is null");
}