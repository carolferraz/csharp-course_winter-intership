using System.Globalization;
using System.Text;

namespace ExerciseAbstractClasses2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayment> list = new List<TaxPayment>();

            Console.Write("Enter the number of tax payers: ");
            int numberOfTaxPayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfTaxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c): ");
                char typeOfTax = char.Parse(Console.ReadLine());

                if (typeOfTax == 'i' || typeOfTax == 'I')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Annual income: ");
                    double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double healthExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    TaxPayment tax = new FisicalPerson(name, annualIncome, healthExpenses);

                    list.Add(tax);
                }
                else if (typeOfTax == 'c' || typeOfTax == 'C')
                {

                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Annual income: ");
                    double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    TaxPayment tax = new LegalPerson(name, annualIncome, numberOfEmployees);

                    list.Add(tax);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("TAXES PAID:");

            double sum = 0.0;
            foreach (TaxPayment taxPayment in list)
            {
                sum += taxPayment.Tax();
                Console.WriteLine(taxPayment.ToString());
            }

            Console.WriteLine("");
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}