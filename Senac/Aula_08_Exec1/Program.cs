using System;
using System.Globalization;

namespace Aula_8_Exec1
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            Fazer um programa para ler uma temperatura em Celsius e mostrar o equivalente em Fahrenheit. 
            Perguntar se o usuário deseja repetir (s/n).
            Caso o usuário digite "s", repetir o programa.
            Digite a temperatura em Celsius:
            Equivalente em Fahrenheit
            Deseja repetir (s / n)
            */
            char repetir;
            // faça
            do{
                // imprime na saida o que o usuario deve informar
                Console.Write("Digite a temperatura em Celsius: ");
                // criar variavel double e atribui o valor do teclado a ela
                double celsius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                double fahrenheit = (celsius * 9.0) / 5.0 + 32;

                Console.WriteLine("Equivalente em Fahrenheit " + 
                fahrenheit.ToString("F1",CultureInfo.InvariantCulture));
                Console.Write("Deseja repetir (s / n): ");
                // atribui à variavel repetir, o valor digitado no teclado
                // e passa
                repetir = char.Parse(Console.ReadLine().ToLower());
            }
            // enquanto
            while(repetir == 's');

        }
    }
}
