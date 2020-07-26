using System;
using S10_aula137_exe_Metodos_Abstratos.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace S10_aula137_exe_Metodos_Abstratos
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("Enter the number of tax payers: ");
            int numberOfTaxPayers = int.Parse(Console.ReadLine());
            List<TaxPayer> listTaxPayers = new List<TaxPayer>();
            double sum = 0.0;

            for (int i = 1; i <= numberOfTaxPayers ; i++) {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char typeOfTaxPayer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (typeOfTaxPayer == 'i') {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Individual individual = new Individual(name, anualIncome, healthExpenditures);
                    listTaxPayers.Add(individual);
                } else {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    Company company = new Company(name, anualIncome, numberOfEmployees);
                    listTaxPayers.Add(company);
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer item in listTaxPayers) {
                sum += item.Tax();
                Console.WriteLine(item.Name + ": $ " + item.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
