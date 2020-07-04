using System;
using System.Globalization;

namespace S1_Prova_exe_2_1 {
    class Program {
        static void Main(string[] args) {
            int cod, qtd;
            double total = 0.0;

            string linha = Console.ReadLine();

            string[] vetLinha = linha.Split(' ');
            cod = Convert.ToInt32(vetLinha[0]);
            qtd = Convert.ToInt32(vetLinha[1]);

            switch (cod) {
                case 1:
                    total = qtd * 4.00;
                    break;

                case 2:
                    total = qtd * 4.50;
                    break;

                case 3:
                    total = qtd * 5.00;
                    break;

                case 4:
                    total = qtd * 2.00;
                    break;

                case 5:
                    total = qtd * 1.50;
                    break;

                default:
                    break;
            }
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
