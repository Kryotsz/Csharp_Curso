using System;
using System.Globalization;

namespace Aula_9_VetorDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            // leitura de N
            N=int.Parse(Console.ReadLine());
            // leitura de valores em formato texto
            string[] linha=Console.ReadLine().Split(' ');
            // declaração de vetor e criação de instância
            double[] valores=new double[N];

            double media, soma=0.0;

            // percorre vetor texto e atribui valores
            for(int i=0;i<N;i++){
                valores[i]=double.Parse(linha[i],CultureInfo.InvariantCulture);
                soma+=valores[i];
            }

            media=soma/N;

            for(int i=0;i<N;i++){
                Console.Write(valores[i].ToString("F1",CultureInfo.InvariantCulture)+" ");
            }

            Console.WriteLine();
            Console.WriteLine(soma.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
