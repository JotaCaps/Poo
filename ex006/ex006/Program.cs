﻿// See https://aka.ms/new-console-template for more information
using System.Globalization;

double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (numero < 0.0 || numero > 100.0)
{
    Console.WriteLine("Fora do Intervalo");
}
else if (numero <= 25.0)
{
    Console.WriteLine("Intervalo (0,25]");
}

else if (numero < 50.0)
{
    Console.WriteLine("Intervalo (25,50]");
}
else if (numero < 75.0)
{
    Console.WriteLine("Intervalo (50,75]");
}
else
{
    Console.WriteLine("Intervalo (75.100]");
} 
