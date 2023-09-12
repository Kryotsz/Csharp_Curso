using System;
using System.Globalization;

namespace Aula_9_VetorDouble3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, idade, menor=0, porcentagem;
            string nome;
            double altura, soma=0.0, media;

            N=int.Parse(Console.ReadLine());

            for(int i=0;i<N;i++){
                string[] vetor=new string[3];
                vetor=Console.ReadLine().Split(' ');
                nome=vetor[0];
                idade=int.Parse(vetor[1]);
                altura=double.Parse(vetor[2],CultureInfo.InvariantCulture);
                
                soma+=altura;

                if(idade<16){
                    menor+=1;
                }
            }

            media=soma/N;
            porcentagem=(menor*100)/N;

            Console.WriteLine("Altura média: "+media.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Pessoas com menos de 16 anos: "+porcentagem+" %");
        }
    }
}
