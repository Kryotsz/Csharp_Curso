using System;

namespace aula_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // vetor string com 3 posições
            string[] banana = new string[3];
            // vetor recebe a leitura do teclado e divida o texto quando encontrar espaço
            Console.Write("Digite 3 palavras separadas por espaço e tecle enter: ");
            banana = Console.ReadLine().Split(' ');
            // imprime os valores do vetor e cada posição
            Console.WriteLine(banana[0]);
            Console.WriteLine(banana[1]);
            Console.WriteLine(banana[2]);

            string nome;
            int idade;
            double peso;

            Console.WriteLine("Informe o nome do cliente, idade e peso separados por espaço: ");
            string[] infos = new string[3];
            infos = Console.ReadLine().Split(' ');

            nome = infos[0];
            idade = int.Parse(infos[1]);
            peso = double.Parse(infos[2]);

            Console.WriteLine("Dados informados");
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(peso.ToString("F2"));
            


        }
    }
}
