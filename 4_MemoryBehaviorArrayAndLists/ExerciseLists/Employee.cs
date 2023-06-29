using System.Globalization;

namespace ListExercise
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public Employee(int id, string name, double salary) : this(name, salary)
        {
            Id = id;

        }
        public void IncreaseSalary(double percentage)
        {
            Salary += (Salary * percentage / 100);
        }

        override public string ToString()
        {
            return Id
            + ", "
            + Name
            + ", "
            + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
