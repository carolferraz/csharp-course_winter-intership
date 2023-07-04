using EnumerationAndComposition.Entities;
using EnumerationAndComposition.Entities.Enums;

namespace EnumerationAndComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //We can work with enums by saving them to text variables, as we can see below. 
            string text = OrderStatus.PendingPayment.ToString(); //Passing the information of the enum to string, using .ToString()
            OrderStatus someStatus = Enum.Parse<OrderStatus>("Delivered"); //Passing the information as a string using the method Parse. Here we are seting the type of the enum that will receive the information with the name we create it "OrderStatus", at the name of the variable and at the parameter of Parse. Note that on Parse, we are parameterizing just like we do with lists. 

            Console.WriteLine(text);
            Console.WriteLine(someStatus);
        }
    }
}