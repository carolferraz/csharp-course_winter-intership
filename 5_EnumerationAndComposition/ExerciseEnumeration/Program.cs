using System.ComponentModel;
using System.Globalization;
using ExerciseEnumeration.Entities;
using ExerciseEnumeration.Entities.Enums;

namespace ExerciseEnumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string departmentName = Console.ReadLine(); //Saving the department in a temporary variable.
            
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine(); //Saving the name in a temporary variable.

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine()); //Saving the level in a temporary variable, and already making the parse to the enum type with its type "WorkerLevel".
            
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(departmentName); //Instantiating the Department class and passing the variable set before.

            Worker worker = new Worker(name, level, baseSalary, department); //Instantiating the Worker class and passing the variables set before, including the department that is attached to it.


            Console.Write("");
            Console.Write("How many contracts to this worker: ");
            int numContracts = int.Parse(Console.ReadLine());

            Console.Write("");

            for (int i = 1; i <= numContracts; i++) //Here we are creating a loop for the number of contracts that the user is specifying to create that number of contracts to the worker.
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR")); //The computer i'm using is set in english, so the information the user will pass may be in portuguese, so we need to use the CultureInfo to "translate" this information.
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (in hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                
                worker.AddContract(contract); //Here we add the contract to the list of contracts in Worker.
            }


            Console.Write("");
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2)); //The .Substring() method has two overloads, in this line we are selecting a piece of element by its index and the final index of that character that we are selecting. In the line below we are passing the index that will start the cut and it will select all the text in front of the index that is passed in in the parameters.
            int year = int.Parse(monthAndYear.Substring(3));
            
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name); //Remember to access the information in and attached class, we need to call the props of the class attached, and the props we need to access.
            Console.WriteLine("Income: " + worker.Income(year, month));

        }
    }
}