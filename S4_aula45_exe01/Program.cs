using System;
using System.Globalization;

namespace S4_aula45_exe01
{
    class Program
    {
        static void Main(string[] args) {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo:");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("AREA = "+ retangulo.Area(largura, altura).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + retangulo.Perimetro(largura, altura).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + retangulo.Diagonal(largura, altura).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
