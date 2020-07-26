﻿using System;
using System.Collections.Generic;
using System.Text;

namespace S10_aula137_exe_Metodos_Abstratos.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }
              
        public Individual(string name, double anualIncome, double healthExpenditures) 
            : base (name, anualIncome) 
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax() {
            double tax = 0.0;
            if (AnualIncome < 20000.0) {
                tax = AnualIncome * 0.15 - HealthExpenditures * 0.5;
            } else {
                tax = AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
            return tax;
        }
    }
}
