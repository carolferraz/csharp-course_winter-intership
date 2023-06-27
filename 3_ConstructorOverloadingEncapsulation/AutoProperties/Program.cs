using System;
using System.Globalization;

namespace AutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("TV", 500.00, 10);

           // product.Quantity = -10; //When we use private on a field declared, it's not posible to reclared the field whitout the a custom method, or a Set method. 

            Console.WriteLine(product.GetName());

            product.SetName("TV 4K");
            Console.WriteLine(product);

            product.SetName("T");
            Console.WriteLine(product);
        }
    }
}