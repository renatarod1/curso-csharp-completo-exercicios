using System;
using System.Globalization;

namespace S3_aula24_exe05
{
    class Program
    {
        static void Main(string[] args) {
            int cod1, cod2, qtd1, qtd2;
            double vl1, vl2, total;

            string[] peca1 = Console.ReadLine().Split(' ');
            string[] peca2 = Console.ReadLine().Split(' ');

            cod1 = int.Parse(peca1[0]);
            qtd1 = int.Parse(peca1[1]);
            vl1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            cod2 = int.Parse(peca2[0]);
            qtd2 = int.Parse(peca2[1]);
            vl2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            total = qtd1 * vl1 + qtd2 * vl2;
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
