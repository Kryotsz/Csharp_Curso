using System.Globalization;

namespace ComPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX;
            double px = (x.A + x.B + x.C) / 2;
            areaX = Math.Sqrt(px * (px - x.A) * (px - x.B) * (px - x.C));

            double areaY;
            double py = (y.A + y.B + y.C) / 2;
            areaY = Math.Sqrt(py * (py - y.A) * (py - y.B) * (py - y.C));

            char maiorArea;

            if (areaX > areaY)
            {
                maiorArea = 'X';
            }
            else
            {
                maiorArea = 'Y';
            }

            Console.WriteLine("Àrea de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Àrea de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior área: " + maiorArea);
        }
    }
}