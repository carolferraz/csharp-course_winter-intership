using System;
using System.Globalization;

namespace FirstExercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AverageSalary();
        }
        public static void AverageSalary()
        {
            Employee p1 = new Employee();
            Employee p2 = new Employee();

            Console.WriteLine("Dados da primeira pessoa funcionária:");
            Console.WriteLine("Nome:");
            p1.Name = Console.ReadLine();
            Console.WriteLine("Salário:");
            p1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da segunda pessoa funcionária:");
            Console.WriteLine("Nome:");
            p2.Name = Console.ReadLine();
            Console.WriteLine("Salário:");
            p2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double average = (p1.Salary + p2.Salary) / 2;

            Console.WriteLine("A média salarial é de: " + average.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
