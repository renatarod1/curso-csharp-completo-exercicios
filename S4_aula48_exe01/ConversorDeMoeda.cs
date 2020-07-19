using System;
using System.Collections.Generic;
using System.Text;

namespace S4_aula48_exe01
{
    class ConversorDeMoeda
    {
        public static double iof = 6.0;

        public static double ConversaoDollarReal(double valorDollar, double quantia) {
            double total = valorDollar * quantia;
            return total = total + iof * total / 100.0; 
        }
    }
}
