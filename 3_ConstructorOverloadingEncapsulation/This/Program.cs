using System;
using System.Globalization;

namespace This
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome:");
            string name = Console.ReadLine();
            Console.Write("Preço do produto:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
            
            Product product = new Product(name, price);
            
            Product product2 = new Product(); //The default constructor won't work if we don't have this declaration in the class as an overloading. This will work by default only if we don't have a custom constructor.

            Product product3 = new Product
            {
                Name = "TV",
                Price = 500.00,
                Quantity = 10
            }; //This is an alternative syntax for declaring fields. See that it's all one a comma-separated line and has a ; only at the end of sentence. This will only work if you have a default constructor or none declared (also default), and it won't work if you have a custom constructor and don't have a default declared.
            
            
            Console.Write("");
            Console.WriteLine("Dados do produto: " + product);

            Console.WriteLine("");
            Console.WriteLine("Digite o número de produtos a serem adicionados ao estoque:");
            int amount = int.Parse(Console.ReadLine());
            product.AddProduct(amount);

            
            Console.Write("");
            Console.WriteLine("Dados atualizados: " + product);

            Console.WriteLine("");
            Console.WriteLine("Digite o número de produtos a serem removido do estoque:");
            amount = int.Parse(Console.ReadLine());
            product.RemoveProduct(amount);


            Console.Write("");
            Console.WriteLine("Dados atualizados: " + product);
        }
    }
}