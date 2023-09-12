using System;
using System.Globalization;

namespace Aula_9_VetorDouble2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N=int.Parse(Console.ReadLine());
            string[] linha=Console.ReadLine().Split();
            double[] valores=new double[N];
            double maior=0.0;
            int posicao=0;
            // percorre o vetor da linha
            for(int i=0;i<N;i++){
                // atribui o valor de cada posicao do vetor linha
                valores[i]=double.Parse(linha[i],CultureInfo.InvariantCulture);
            }

            // percorre o vetor de valores double
            for(int i=0; i<N;i++){
                // se vetor na posicao i for maior que a var maior
                if(valores[i]>maior){
                    // atribui o valor da var maior ao valores na posicao i
                    maior=valores[i];
                    // atribui o valor da var posicao ao valor do inidice i
                    posicao=i;
                }
            }
            Console.WriteLine(maior.ToString("F1",CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
        }
    }
}
