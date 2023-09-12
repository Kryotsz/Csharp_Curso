﻿using ex01;
using System.Globalization;

Retangulo retangulo = new Retangulo();

Console.WriteLine("Entre a largura e altura do retângulo:");
retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double area = retangulo.Area();
double perimetro = retangulo.Perimetro();
double diagonal = retangulo.Diagonal();

Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PERÍMETRO = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " + diagonal.ToString("F2", CultureInfo.InvariantCulture));