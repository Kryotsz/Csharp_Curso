using System;
using System.Globalization;

namespace Aula_3_Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, nome2;
            int quartos, idade;
            double preço, altura;

            nome=Console.ReadLine();
            quartos=int.Parse(Console.ReadLine());
            preço=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            string[] vetor=new string[3];

            vetor=Console.ReadLine().Split(" ");
            nome2=vetor[0];
            idade=int.Parse(vetor[1]);
            altura=double.Parse(vetor[2]);

            Console.WriteLine(nome);
            Console.WriteLine(preço.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(nome2);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"));

        }
    }
}
