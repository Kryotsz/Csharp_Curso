using ex01;
using System.Globalization;

Console.Write("Qual é a cotação do dólar? ");
decimal cotacao = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantos dólares você vai comprar? ");
decimal valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

decimal valorPago = ConversorDeMoeda.Conversao(cotacao, valor);

Console.WriteLine("Valor a ser pago em reais = " + valorPago.ToString("F2", CultureInfo.InvariantCulture));