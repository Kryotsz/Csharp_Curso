using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Digite o seu nome:");

            var nome = Console.ReadLine();

            Console.WriteLine("Bem vindo " + nome);

            Console.ReadKey();

        }
    }
}
