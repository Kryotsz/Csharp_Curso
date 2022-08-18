using System;

namespace Checklist
{
    class Program
    {
        static void Main(string[] args)
        {
            //ler int
            //ler caractere
            //ler um double
            //ler nome sexo idade altura
            //string int char double

            int inteiro;
            char caractere;
            double peso;

            string[] info1=new string[3];
            Console.Write("Digite um número inteiro, um único caractere e seu peso, separados por espaço: ");
            info1=Console.ReadLine().Split(' ');
            inteiro=int.Parse(info1[0]);
            caractere=char.Parse(info1[1]);
            peso=double.Parse(info1[2]);
            Console.WriteLine(inteiro);
            Console.WriteLine(caractere);
            Console.WriteLine(peso.ToString("F2"));

            string nome;
            char sexo;
            int idade;
            double altura;

            string[] info=new string[4];
            Console.Write("Digite seu nome, sexo(M ou F), idade e altura, todos separados por espaço: ");
            info=Console.ReadLine().Split(' ');

            nome=info[0];
            sexo=char.Parse(info[1]);
            idade=int.Parse(info[2]);
            altura=double.Parse(info[3]);

            Console.Write(nome+" ");
            Console.Write(sexo+" ");
            Console.Write(idade+" ");
            Console.Write(altura.ToString("F2")+" ");
            
        }
    }
}
