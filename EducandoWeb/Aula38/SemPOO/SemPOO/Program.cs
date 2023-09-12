using System;
using System.Globalization;

namespace SemPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X: ");
            double ax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double bx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double cx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            double ay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double by = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double cy = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX;
            double px = (ax + bx + cx) / 2;
            areaX = Math.Sqrt(px * (px - ax) * (px - bx) * (px - cx));

            double areaY;
            double py = (ay + by + cy) / 2;
            areaY = Math.Sqrt(py * (py - ay) * (py - by) * (py - cy));

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