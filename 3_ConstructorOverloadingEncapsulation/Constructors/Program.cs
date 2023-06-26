using System;
using System.Globalization;

namespace Constructor
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
            Console.Write("Quantidade no estoque: ");
            int quantity = int.Parse(Console.ReadLine());

            
            Product product = new Product(name, price, quantity);
            
            
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