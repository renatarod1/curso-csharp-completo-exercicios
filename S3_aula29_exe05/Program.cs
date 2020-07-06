using System;
using System.Globalization;

namespace S3_aula29_exe05
{
    class Program
    {
        static void Main(string[] args) {
            double total = 0.0;
            string[] codQtd = Console.ReadLine().Split(' ');
            int cod = int.Parse(codQtd[0]);
            int qtd = int.Parse(codQtd[1]);

            if (cod == 1) {
                total = qtd * 4.0;
            }
            else if (cod == 2) {
                total = qtd * 4.5;
            }
            else if (cod == 3) {
                total = qtd * 5.0;
            }
            else if (cod == 4) {
                total = qtd * 2.0;
            }
            else {
                total = qtd * 1.5;
            }
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
