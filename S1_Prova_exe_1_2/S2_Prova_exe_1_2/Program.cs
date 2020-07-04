using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Prova_exe_1_2 {
    class Program {
        static void Main(string[] args) {

            const double pi = 3.14159;
            double area, raio;

            raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = pi * Math.Pow(raio, 2);
            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
