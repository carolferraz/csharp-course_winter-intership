using System;
using System.Globalization;

namespace ClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();


            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome:");
            product.Name = Console.ReadLine();
            Console.Write("Preço do produto:");
            product.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            product.Quantity = int.Parse(Console.ReadLine());

            Console.Write("");
            Console.WriteLine("Dados do produto: " + product);

            Console.WriteLine("");
            Console.WriteLine("Digite o número de produtos a serem adicionados ao estoque:");
            int amount = int.Parse(Console.ReadLine());
            product.AddProduct(amount);

            Console.Write("");
            Console.WriteLine("Dados atualizados: " + product);

            Console.WriteLine("");
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque:");
            amount = int.Parse(Console.ReadLine());
            product.RemoveProduct(amount);


            Console.Write("");
            Console.WriteLine("Dados atualizados: " + product);
        }
    }
}