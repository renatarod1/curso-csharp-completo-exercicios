using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace S4_aula45_exe02
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto += (porcentagem / 100.0 * SalarioBruto);
        }

        public override string ToString() {
            return Nome + ", R$" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
