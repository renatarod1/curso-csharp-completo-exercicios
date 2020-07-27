using S14_aula199_exe_Interfaces.Entities;
using System;
using S14_aula199_exe_Interfaces.Services;
using System.Globalization;

namespace S14_aula199_exe_Interfaces
{
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());
            Contract contract = new Contract(number, date, totalValue);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, months);
            Console.WriteLine("Installments:");
            foreach (var item in contract.Installments) {
                Console.WriteLine(item.DueDate.ToString("dd/MM/yyyy" + " - " + item.amount.ToString("F2", CultureInfo.InvariantCulture)));
            }
        } 
    }   
}
