using System;
using System.Globalization;

namespace S4_aula40_exe02
{
    class Program
    {
        static void Main(string[] args) {
            Funcionario a = new Funcionario();
            Funcionario b = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            a.nome = Console.ReadLine(); 
            Console.Write("Salário: ");
            a.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            b.nome = Console.ReadLine();
            Console.Write("Salário: ");
            b.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salarioMedio = (a.salario + b.salario) / 2.0;         
            Console.WriteLine("Salario médio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
