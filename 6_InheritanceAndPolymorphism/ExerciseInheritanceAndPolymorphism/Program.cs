using ExerciseInheritanceAndPolymorphism.Entities;
using System.Collections.Generic;

namespace ExerciseInheritanceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> listOfEmployees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int numberOfEmployess = int.Parse(Console.ReadLine());


            for (int i = 1; i <= numberOfEmployess; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char isOutsourced = char.Parse(Console.ReadLine());

                if (isOutsourced == 'y' || isOutsourced == 'Y')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());

                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine());

                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    Employee outSourceEmployee = new OutSourceEmployee(name, hours, valuePerHour, additionalCharge);

                    listOfEmployees.Add(outSourceEmployee);
                }
                else if (isOutsourced == 'n' || isOutsourced == 'N')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());

                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine());

                    
                    Employee employee = new Employee(name, hours, valuePerHour);

                    listOfEmployees.Add(employee);
                }
            }

            Console.WriteLine("PAYMENTS:");
            foreach (Employee employee in listOfEmployees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}