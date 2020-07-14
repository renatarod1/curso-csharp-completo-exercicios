using System;
using System.Globalization;

namespace S3_aula35_exe04
{
    class Program
    {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());            

            for (int i = 0; i < n; i++) {
                string[] vetLine = Console.ReadLine().Split(' ');
                int n1 = int.Parse(vetLine[0]);
                int n2 = int.Parse(vetLine[1]);

                if (n2 == 0) {
                    Console.WriteLine("divisao impossivel");
                } else {
                    double result = (double) n1 / n2;
                    Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
