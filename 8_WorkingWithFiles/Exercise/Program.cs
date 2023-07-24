using System.Globalization;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<Product> productsList = new List<Product>{
            //     new Product{Name = "TV LED", Price = 1200.99, Quantity = 1},
            //     new Product{Name = "Video Game Chair", Price = 350.50, Quantity = 3},
            //     new Product{Name = "Iphone X", Price = 900.00, Quantity = 2},
            //     new Product{Name = "Samsung Galaxy 9", Price = 850.00, Quantity = 2},
            // };

            // List<string> strings =  new List<string>();

            // foreach (Product product in productsList)
            // {
            //     strings.Add(product.ToString());
            // }

            // File.WriteAllLines(@"C:\Users\caroline.ferraz\Documents\CSharp_CursoCompleto\8_WorkingWithFiles\Exercise\products.csv", strings);

            try
            {
                Console.WriteLine("Enter the full path of the archive: ");
                string sourceFilePath = Console.ReadLine();

                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string newFolderPath = sourceFolderPath + @"\out\summary.csv";
                Directory.CreateDirectory(newFolderPath);

                string destinyFilePath = newFolderPath + @"\summary.csv";
                using (StreamWriter streamWriter = File.AppendText(destinyFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(",");
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product product = new Product(name, price, quantity);

                        streamWriter.WriteLine(product.Name + ", " + product.Total().ToString("F2", CultureInfo.InvariantCulture));

                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("We found an error:");
                Console.WriteLine(e.Message);
            }


        }
    }
}