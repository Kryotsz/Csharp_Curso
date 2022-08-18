using System;
using System.Globalization;

namespace uri1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, resto1, resto2, resto3, resto4, resto5, resto6, resto7, resto8, resto9, resto10, resto11, moeda050, moeda025, moeda010, moeda005, moeda001;
            int nota100, nota50, nota20, nota10, nota5, nota2, moeda1;

            N=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            nota100=(int)N/100;
            resto1=N%100;
            nota50=(int)resto1/50;
            resto2=resto1%50;
            nota20=(int)resto2/20;
            resto3=resto2%20;
            nota10=(int)resto3/10;
            resto4=resto3%10;
            nota5=(int)resto4/5;
            resto5=resto4%5;
            nota2=(int)resto5/2;
            resto6=resto5%2;
            moeda1=(int)resto6/1;
            resto7=resto6%1;
            moeda050=resto7*100/50;
            resto8=resto7%0.50;
            moeda025=resto8*100/25;
            resto9=resto8%0.25;
            moeda010=resto9*100/10;
            resto10=resto9%0.10;
            moeda005=resto10*100/5;
            resto11=resto10%0.05;
            moeda001=resto11*100/1;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(nota100+" nota(s) de R$ 100.00");
            Console.WriteLine(nota50+" nota(s) de R$ 50.00");
            Console.WriteLine(nota20+" nota(s) de R$ 20.00");
            Console.WriteLine(nota10+" nota(s) de R$ 10.00");
            Console.WriteLine(nota5+" nota(s) de R$ 5.00");
            Console.WriteLine(nota2+" nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(moeda1+" moeda(s) de R$ 1.00");
            Console.WriteLine(Math.Floor(moeda050)+" moeda(s) de R$ 0.50");
            Console.WriteLine(Math.Floor(moeda025)+" moeda(s) de R$ 0.25");
            Console.WriteLine(Math.Floor(moeda010)+" moeda(s) de R$ 0.10");
            Console.WriteLine(Math.Floor(moeda005)+" moeda(s) de R$ 0.05");
            Console.WriteLine(Math.Floor(moeda001)+" moeda(s) de R$ 0.01");
        }
    }
}
