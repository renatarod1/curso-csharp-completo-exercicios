using System;
using System.Globalization;

namespace S3_aula35_exe03
{
    class Program
    {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());           
            
            for (int i = 1; i <= n; i++) {
                string[] vetLine = Console.ReadLine().Split(' ');
                double n1 = double.Parse(vetLine[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(vetLine[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(vetLine[2], CultureInfo.InvariantCulture);
                double media = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / 10.0;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
