using System;
using System.Collections.Generic;
using System.Text;

namespace S4_aula45_exe01
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area(double largura, double altura) {
            return largura * altura;
        }

        public double Perimetro(double largura, double altura) {
            return 2 * (largura + altura);
        }

        public double Diagonal(double largura, double altura) {
            double res = Math.Sqrt(largura * largura + altura * altura);
            return res;
        }
    }
}
