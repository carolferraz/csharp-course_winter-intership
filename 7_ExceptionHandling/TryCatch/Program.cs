using System.Globalization;
using TryCatch.Entities;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));


            if (checkOut <= checkIn)
            {
                Console.Write("Error in reservation: check-out date must be after check-in date.");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

                Console.WriteLine("Reservation: " + reservation.ToString());

                Console.WriteLine("");
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

                string error = reservation.UpdateDates(checkIn, checkOut);
                
                if (error != null)
                {
                    Console.WriteLine("Error in reservation: " + error);
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation.ToString());
                }

            }



        }
    }
}