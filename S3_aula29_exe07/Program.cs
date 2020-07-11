using System;
using System.Globalization;

namespace S3_aula29_exe07
{
    class Program
    {
        static void Main(string[] args) {
                        
            string[] vetLine = Console.ReadLine().Split(' ');
            double x = double.Parse(vetLine[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vetLine[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0) {
                Console.WriteLine("Origem");
            } else if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Q1");
            } else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("Q2");
            } else if (x < 0.0 && y < 0.0){
                Console.WriteLine("Q3");
            } else {
                Console.WriteLine("Q4");
            }
        }
    }
}
