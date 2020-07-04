using System;
using System.Globalization;

namespace S1_Prova_exe_1_1 {
    class Program {
        static void Main(string[] args) {

            int codPeca1, qtdPeca1, codPeca2, qtdPeca2;
            double valorPeca1, valorPeca2;

            string linha1 = Console.ReadLine();
            string linha2 = Console.ReadLine();

            string[] vetorlinha1 = linha1.Split(' ');
            string[] vetorlinha2 = linha2.Split(' ');

            codPeca1 = Convert.ToInt32(vetorlinha1[0]);
            qtdPeca1 = Convert.ToInt32(vetorlinha1[1]);
            valorPeca1 = double.Parse(vetorlinha1[2], CultureInfo.InvariantCulture);

            codPeca2 = Convert.ToInt32(vetorlinha2[0]);
            qtdPeca2 = Convert.ToInt32(vetorlinha2[1]);
            valorPeca2 = double.Parse(vetorlinha2[2], CultureInfo.InvariantCulture);

            double total = qtdPeca1 * valorPeca1 + qtdPeca2 * valorPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
