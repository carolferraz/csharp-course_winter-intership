using System.Globalization;
using ExerciseExceptionHandling.Entities;
using ExerciseExceptionHandling.Entities.Exceptions;

namespace ExerciseExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Inicial balance: ");
            double inicialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, inicialBalance, withdrawLimit);

            Console.Write("");
            Console.Write("Enter amount for withdraw: ");
            double withdrawalAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
            account.Withdraw(withdrawalAmount);

            Console.Write("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainExceptions excep)
            {
                Console.WriteLine("Withdraw error: " + excep.Message);
            }
            catch (FormatException excep)
            {
                Console.WriteLine("Format error: " + excep.Message);
            }
            catch (Exception excep)
            {
                Console.WriteLine("Unexpected error: " + excep.Message);
            }

        }
    }
}