using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace S5_aula60_exe01
{
    class Conta
    {
        public int Numero { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string nomeTitular) {
            this.Numero = numero;
            this.NomeTitular = nomeTitular;           
        }

        public Conta(int numero, string nomeTitular, double depositoInicial) : this(numero, nomeTitular) {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor) {
            this.Saldo += valor;
        }

        public void Saque(double valor) {
            this.Saldo -= 5.0;
            this.Saldo -= valor;
        }

        public override string ToString() {
            return "Conta " + this.Numero + ", Titular: " + this.NomeTitular + ", Saldo: $ " +
                this.Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
