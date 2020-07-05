using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Prova_exe_2_2 {
    class Program {
        static void Main(string[] args) {
            double a, b, c, x1, x2, delta;

            string linha = Console.ReadLine();
            string[] vetLinha = linha.Split(' ');

            a = Convert.ToDouble(vetLinha[0], CultureInfo.InvariantCulture);
            b = Convert.ToDouble(vetLinha[1], CultureInfo.InvariantCulture);
            c = Convert.ToDouble(vetLinha[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            if (a == 0.0 || delta < 0.0) {
                Console.WriteLine("Impossivel calcular");
            } else {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("X1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
                Console.ReadKey();
            }
        }
    }
}
