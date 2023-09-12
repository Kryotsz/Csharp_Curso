using System;
using System.Globalization;

namespace Aula_6_ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, final;

            nota1=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            nota2=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            final=(nota1+nota2);

            Console.WriteLine("NOTA FINAL = "+final.ToString("F1",CultureInfo.InvariantCulture));

            if((final*10)<600.00){
                Console.WriteLine("REPROVADO");
            }
        }
    }
}
