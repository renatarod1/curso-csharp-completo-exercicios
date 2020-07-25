using S9_aula123_exeComposicao.Entities;
using S9_aula123_exeComposicao.Entities.Enums;
using System;
using System.Globalization;

namespace S9_aula123_exeComposicao
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine()).ToUniversalTime();            
            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.UtcNow, status, client);

            Console.Write("How many items to this order? ");
            int qtdOrderItems = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdOrderItems; i++) {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProd = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());                               
                OrderItem orderItem = new OrderItem(quantity, price, new Product(nameProd, price));
                order.AddItem(orderItem);                
            }
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
