using System;
using System.Collections.Generic;
using System.Globalization;

namespace S6_aula78_exe01
{
    class Program
    {
        static void Main(string[] args) {
            List<Funcionario> listaFuncionarios = new List<Funcionario>();

            Console.Write("How many employees will be registered? ");
            int numFuncionarios = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numFuncionarios; i++) {
                Console.WriteLine("Emplyoee #"+ i +": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listaFuncionarios.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }            
            Console.Write("Enter the employee id that will have salary increase : ");
            int idAumento = int.Parse(Console.ReadLine());            
            Funcionario func = listaFuncionarios.Find(x => x.Id == idAumento);
            if (func != null) {
                Console.Write("Enter the percentage: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentarSalario(porcentagem);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (var item in listaFuncionarios) {
                Console.WriteLine(item);
            }
        }
    }
}
