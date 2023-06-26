using System.Globalization;

namespace ExerciseTwo{
    public class Employee
    {
        public string Name;
        public double GrossSalary;
        public double Tax;

        public double NetSalary()
        {
            return GrossSalary - Tax;
        }

        public void CalculatePercentage(double percentage)
        {
            GrossSalary += ((GrossSalary * percentage) / 100);

        }

        public override string ToString()
        {
            return Name
            + ", "
            + NetSalary().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}