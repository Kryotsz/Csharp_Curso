using System;
using System.Globalization;

namespace Aula_3_Resolvido_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, quadrado, AREA, PRECO;

            largura=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            comprimento=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            quadrado=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            AREA=largura*comprimento;
            PRECO=AREA*quadrado;

            Console.WriteLine("AREA-"+AREA.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO="+PRECO.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
