using System;
using System.Globalization;
using S11_aula146_exeExceptions.Entities;
using S11_aula146_exeExceptions.Entities.Exceptions;

namespace S11_aula146_exeExceptions
{
    class Program
    {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account account = new Account(number, holder, initialBalance, withdrawLimit);
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.WithDraw(amount);
                Console.WriteLine("New balance: " + account);
            }
            catch (DomainException e) {
                Console.WriteLine(e.Message); ;
            }
        }
    }
}
