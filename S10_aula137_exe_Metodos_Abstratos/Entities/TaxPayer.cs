using System;
using System.Collections.Generic;
using System.Text;

namespace S10_aula137_exe_Metodos_Abstratos.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer(string name, double anualIncome) {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
