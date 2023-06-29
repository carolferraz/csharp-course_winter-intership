using System.Globalization;
using System.Transactions;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Example2();
        }

        static void Example1()
        {
            int n = int.Parse(Console.ReadLine());

            double[] vector = new double[n];

            for (int i = 0; i < n; i++)
            {
                vector[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vector[i];
            }

            double average = sum / n;

            Console.WriteLine("AVERAGE HEIGHT = " + average.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void Example2()
        {
            Console.WriteLine("Entre com o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vector = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vector[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vector[i].Price;
            }

            double averagePrice = sum / n;

            Console.WriteLine("AVERAGE PRICE = " + averagePrice.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}