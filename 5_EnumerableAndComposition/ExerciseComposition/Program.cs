using System.Globalization;
using ExerciseComposition.Entities;
using ExerciseComposition.Entities.Enums;

namespace ExerciseComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

            Client client = new Client(name, email, birthDate);

            Console.Write("");
            Console.WriteLine("Enter order data:");
            Console.Write("Status:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            DateTime moment = DateTime.Now;

            Order order = new Order(moment, status, client);

            Console.Write("How many items to this order?");
            int numberOfOrders = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfOrders; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Product product = new Product(productName, price);
                
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine("");
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
            

        }
    }
}