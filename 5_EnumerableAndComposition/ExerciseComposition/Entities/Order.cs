using ExerciseComposition.Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace ExerciseComposition.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public Client Client { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        override public string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss")); //To set the template of a date use the method ToString with the way that you want it appears.
            stringBuilder.AppendLine("Order status: " + Status);
            stringBuilder.AppendLine("Client: " + Client);
            
            stringBuilder.AppendLine("Order items: ");
            foreach (OrderItem item in Items)
            {
                stringBuilder.AppendLine(item.ToString());
            }
            
            stringBuilder.AppendLine("Total price: $" + Total().ToString("F2"));

            return stringBuilder.ToString();
        }

    }
}