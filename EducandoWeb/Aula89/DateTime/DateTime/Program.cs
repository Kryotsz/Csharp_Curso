using System.Globalization;

DateTime d1 = new DateTime(2023, 09, 22);
DateTime d2 = new DateTime(2023, 09, 22, 11, 50, 00);
DateTime d3 = new DateTime(2023, 09, 22, 11, 50, 9, 500);

DateTime d4 = DateTime.Now;
DateTime d5 = DateTime.Today;
DateTime d6 = DateTime.UtcNow;

DateTime d7 = DateTime.Parse("2000-08-15");
DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");

DateTime d9 = DateTime.Parse("15/08/2000");
DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");

DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(d3);
Console.WriteLine(d4);
Console.WriteLine(d5);
Console.WriteLine(d6);
Console.WriteLine(d7);
Console.WriteLine(d8);
Console.WriteLine(d9);
Console.WriteLine(d10);
Console.WriteLine(d11);
Console.WriteLine(d12);