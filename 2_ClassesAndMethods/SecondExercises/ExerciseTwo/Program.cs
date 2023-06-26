using System.Globalization;

namespace ExerciseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee= new Employee();

            Console.Write("Nome: ");
            employee.Name = Console.ReadLine();
            Console.Write("Salário: ");
            employee.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            employee.Tax = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Funcionário: " + employee);
            Console.WriteLine("");
            
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            employee.CalculatePercentage(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("");

            Console.WriteLine("Dados atualizados: " + employee);



        }
    }

}