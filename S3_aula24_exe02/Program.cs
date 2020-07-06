using System;
using System.Globalization;

namespace S3_aula24_exe02
{
    class Program
    {
        static void Main(string[] args) {
            const double pi = 3.14159;
            
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = pi * Math.Pow(raio, 2);
            Console.WriteLine("A="+ area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
