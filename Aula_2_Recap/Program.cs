using System;

namespace Recap
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar variaveis primitivas
            int idade = 20;
            double peso = 80.5;
            string nome = "Igor Gassen";
            var sobrenome = "Hoffmann";
            int distancia;
            char letra = 'A';
            decimal totalVenda = 0;
            bool ehVerdadeEsseBilete = false;

            // complexas
            String frase = "Quero ver, outra vez, seus olhinhos de noite serena.";
            Double subTotal = 0;


            Console.Write("Digite a sua idade: ");
            // idade recebe string do teclado e converte para inteiro
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();

            Console.Write("Quantos Kms você já correu? ");
            distancia = int.Parse(Console.ReadLine());

            Console.Write("Digite o total da venda: ");
            totalVenda = decimal.Parse(Console.ReadLine());

            Console.Write("Você leu os slides da aula passada?(s/n)");
            var entrada = Console.ReadLine();
            ehVerdadeEsseBilete = entrada == "s"? true:false;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dados informados");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sobrenome: " + sobrenome);
            Console.WriteLine("Kms: " + distancia);
            Console.WriteLine("Total da venda: " + totalVenda);
            Console.WriteLine("Leu os slides: " + ehVerdadeEsseBilete);
            Console.WriteLine("---------------------------");
            Console.ForegroundColor = ConsoleColor.White;


        }
    }
}
