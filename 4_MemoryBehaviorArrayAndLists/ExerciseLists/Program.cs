using System.Globalization;

namespace ListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list that has a type called Employee employeesList and that will be populated with employees.
            List<Employee> employeesList = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employeesList.Add(new Employee(id, name, salary)); //Populates the employeesList with new instances of Employee and that receive the id, name and salary given from user.
            }

            Console.WriteLine(" ");
            Console.Write("Enter the employee id that will have salary increase: ");
            int checkId = int.Parse(Console.ReadLine());

            Employee foundEmployee = employeesList.Find(item => item.Id == checkId); //Here I create a new variable that has the Employee type and filters the employee by his Id. It will save the element with all its fields in the "foundEmployee" variable, and if the Id is not found, the return will be null.

            if (foundEmployee != null) //Here I'm checking if the foundEmployee has any value stored. If true it will go into the 'if' statement, if not, it will go to the 'else'.
            {
                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                foundEmployee.IncreaseSalary(percentage);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("This id does not existe!");
            }


            Console.WriteLine(" ");
            Console.WriteLine("Updated list of employees:");

            foreach (Employee employee in employeesList) //Here we are saying: for each element that has a type Employee on the employeesList, do this:
            {
                Console.WriteLine(employee.ToString());
            }


        }


    }
}