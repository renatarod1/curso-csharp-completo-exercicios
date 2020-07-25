using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using S9_aula123_exeComposicao.Entities.Enums;

namespace S9_aula123_exeComposicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client;
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order() {
        }

        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem) {
            OrderItems.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem) {
            OrderItems.Remove(orderItem);
        }

        public override string ToString() {
            double sum = 0.0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment.ToLocalTime().ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status.ToString());
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");            
            foreach (var item in OrderItems) {
                sb.AppendLine(item.ToString());
                sum += item.SubTotal();
            }
            sb.AppendLine("Total price: $" + sum.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
