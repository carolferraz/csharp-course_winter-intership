using System;
using System.Globalization;

namespace Properties
{
    class Program
    {
        /*Using a private method we can hide the information of an object, only showing the safe information. In this exemple, we are manually implementing the Get and Set methods. On the class it's posible to see the details of logic in each method.*/ 
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