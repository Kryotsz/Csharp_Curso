using System;
using System.Globalization;

namespace Aula_6_1021_Correcao
{
    class Program
    {
        static void Main(string[] args)
        {
            // array de notas
            decimal[] notas={100.00M, 50.00M, 20.00M, 10.00M, 5.00M, 2.00M};
            int[] qtdNotas={0,0,0,0,0,0};
            decimal[] moedas={1.00M, 0.50M, 0.25M, 0.10M, 0.05M, 0.01M};
            int[] qtdMoedas={0,0,0,0,0,0};

            decimal entrada=decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // notas
            // se entrada for maior que 100
            if(entrada>=notas[0]){
                // qtdNotas recebe entrada/100
                qtdNotas[0]=(int)Math.Floor(entrada/100);
                // entrada recebe o resto da divisao por 100
                entrada=entrada%100;
            }

            // se entrada for maior que 50
            if(entrada>=notas[1]){
                // qtdNotas recebe entrada/50
                qtdNotas[1]=(int)Math.Floor(entrada/50);
                // entrada recebe o resto da divisao por 50
                entrada=entrada%50;
            }

            if(entrada>=notas[2]){
                qtdNotas[2]=(int)Math.Floor(entrada/20);
                entrada=entrada%20;
            }

             if(entrada>=notas[3]){
                qtdNotas[3]=(int)Math.Floor(entrada/10);
                entrada=entrada%10;
            }

             if(entrada>=notas[4]){
                qtdNotas[4]=(int)Math.Floor(entrada/5);
                entrada=entrada%5;
            }

            if(entrada>=notas[5]){
                qtdNotas[5]=(int)Math.Floor(entrada/2);
                entrada=entrada%2;
            }

            if(entrada>=moedas[0]){ //1.00
                qtdMoedas[0]=(int)Math.Floor(entrada/moedas[0]);
                entrada=entrada%moedas[0];
            }

            if(entrada>=moedas[1]){ //0.50
                qtdMoedas[1]=(int)Math.Floor(entrada/moedas[1]);
                entrada=entrada%moedas[1];
            }

            if(entrada>=moedas[2]){ //0.25
                qtdMoedas[2]=(int)Math.Floor(entrada/moedas[2]);
                entrada=entrada%moedas[2];
            }

            if(entrada>=moedas[3]){ //0.10
                qtdMoedas[3]=(int)Math.Floor(entrada/moedas[3]);
                entrada=entrada%moedas[3];
            }

            if(entrada>=moedas[4]){ //0.05
                qtdMoedas[4]=(int)Math.Floor(entrada/moedas[4]);
                entrada=entrada%moedas[4];
            }

            if(entrada>=moedas[5]){ //0.01
                qtdMoedas[5]=(int)Math.Floor(entrada/moedas[5]);
                entrada=entrada%moedas[5];
            }

            Console.WriteLine("NOTAS:");

            // para i=0 até que i<=5, incremente i com 1
            for(int i=0;i<=5;i++){
                Console.WriteLine(qtdNotas[i]+" nota(s) de R$ "+notas[i].ToString("F2",CultureInfo.InvariantCulture));
            }
            // Console.WriteLine(qtdNotas[0]+" nota(s) de R$ 100.00");
            // Console.WriteLine(qtdNotas[1]+" nota(s) de R$ 50.00");
            // Console.WriteLine(qtdNotas[2]+" nota(s) de R$ 25.00");
            // Console.WriteLine(qtdNotas[3]+" nota(s) de R$ 10.00");
            // Console.WriteLine(qtdNotas[4]+" nota(s) de R$ 5.00");
            // Console.WriteLine(qtdNotas[5]+" nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");

            for(int i=0;i<=5;i++){
                Console.WriteLine(qtdMoedas[i]+" moeda(s) de R$ "+moedas[i].ToString("F2",CultureInfo.InvariantCulture));
            }
            // Console.WriteLine(qtdMoedas[0]+" moeda(s) de R$ 1.00");
            // Console.WriteLine(qtdMoedas[1]+" moeda(s) de R$ 0.50");
            // Console.WriteLine(qtdMoedas[2]+" moeda(s) de R$ 0.25");
            // Console.WriteLine(qtdMoedas[3]+" moeda(s) de R$ 0.10");
            // Console.WriteLine(qtdMoedas[4]+" moeda(s) de R$ 0.05");
            // Console.WriteLine(qtdMoedas[5]+" moeda(s) de R$ 0.01");
        }
    }
}
