using System.Globalization;
using ExerciseWithoutInterface.Entities;
using ExerciseWithoutInterface.Services;

namespace ExerciseWithoutInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");   
            Console.Write("Car model: ");  
            string carModel = Console.ReadLine(); 
            Console.Write("Pichup (dd/MM/yyyy hh:mm): ");   
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");   
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Enter price per hour: ");   
            double priceHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            Console.Write("Enter price per day: ");   
            double priceDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

            CarRental carRental = new CarRental(start, finish, new Vehicle(carModel));
            RentalService rentalService = new RentalService(priceHour, priceDay, new BrazilTaxService()); //Here we intantiate an rental Service that receive a specific dependency, in this case the concrete class BrazilTaxSerice, and it will conect with the ITaxService of the constructor by upcasting. In another word BrazilTaxService, is an ITaxService.
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}