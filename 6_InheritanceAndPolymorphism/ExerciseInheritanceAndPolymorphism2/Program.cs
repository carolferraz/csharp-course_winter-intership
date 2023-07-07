using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using ExerciseInheritanceAndPolymorphism2.Entities;

namespace ExerciseInheritanceAndPolymorphism2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productsList = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfProducts; i++)
            {
                Console.Write($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char typeOfProduct = char.Parse(Console.ReadLine());

                if (typeOfProduct == 'c' || typeOfProduct == 'C')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Product common = new Product(name, price);
                    productsList.Add(common);

                }
                else if (typeOfProduct == 'u' || typeOfProduct == 'U')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

                    Product used = new UsedProducts(name, price, manufactureDate);
                    productsList.Add(used);
                }
                else if (typeOfProduct == 'i' || typeOfProduct == 'I')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Product imported = new ImportedProduct(name, price, customsFee);
                    productsList.Add(imported);
                }
            }

            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in productsList)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}