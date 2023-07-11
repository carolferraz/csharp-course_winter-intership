using System.Globalization;
using CustomExceptions.Entities;
using CustomExceptions.Entities.Exceptions;

namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.Write("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

            Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation.ToString());

            Console.WriteLine("");
            Console.WriteLine("Enter data to update the reservation: ");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));
            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));


            reservation.UpdateDates(checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation.ToString());
            
            }
            catch (DomainExpection excep)
            {
                Console.WriteLine("Error in reservation: " + excep.Message);
            }
            catch (FormatException excep)
            {
                Console.WriteLine("Format error: " + excep.Message);
            }
            catch (Exception excep)
            {
                Console.WriteLine("Unespected error: " + excep.Message);
            }
        }


    }
}