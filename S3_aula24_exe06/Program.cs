using System;
using System.Globalization;

namespace S3_aula24_exe06
{
    class Program
    {
        static void Main(string[] args) {
            const double pi = 3.14159;

            string[] abc = Console.ReadLine().Split(' ');
            double a = double.Parse(abc[0], CultureInfo.InvariantCulture);
            double b = double.Parse(abc[1], CultureInfo.InvariantCulture);
            double c = double.Parse(abc[2], CultureInfo.InvariantCulture);

            Console.WriteLine("TRIANGULO: " + (a * c / 2.0).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + (pi * (c * c)).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + ((a + b) * c / 2).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + (b * b).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + (a * b).ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
