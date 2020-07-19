using System;
using System.Globalization;

namespace S4_aula48_exe01
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("Qual é a cotação do dólar? ");
            double valorDollar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em reais = " + 
                ConversorDeMoeda.ConversaoDollarReal(valorDollar, quantia).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
