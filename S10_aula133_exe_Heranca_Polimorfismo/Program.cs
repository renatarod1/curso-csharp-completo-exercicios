using System;
using System.Collections.Generic;
using System.Globalization;
using S10_aula133_exe_Heranca_Polimorfismo.Entities;

namespace S10_aula133_exe_Heranca_Polimorfismo
{
    class Program
    {
        static void Main(string[] args) {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfProducts; i++) {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char typeOfProduct = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (typeOfProduct) {
                    case 'c':                        
                        products.Add(new Product(name, price));
                        break;

                    case 'i':
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Product importedProduct = new ImportedProduct(name, price, customsFee);
                        products.Add(importedProduct);
                        break;

                    case 'u':                        
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        Product usedProduct = new UsedProduct(name, price, manufactureDate);
                        products.Add(usedProduct);
                        break;

                    default:
                        Console.WriteLine("Incorrect option, choose (c/u/i).");
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product item in products) {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}
