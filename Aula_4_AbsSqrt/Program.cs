using System;
using System.Globalization;

namespace Aula_4_AbsSqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, raiz;

            Console.Write("Informe um valor: ");

            valor=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            raiz=Math.Sqrt(valor);

            Console.WriteLine("Raiz quadrade de "+valor+": "+raiz);
        }
    }
}
