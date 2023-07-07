using System.Globalization;
using System.Text;

namespace ExerciseInheritanceAndPolymorphism.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }

        override public string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            
             stringBuilder.Append(Name);
             stringBuilder.Append(" - $ ");
             stringBuilder.Append(Payment().ToString("F2", CultureInfo.InvariantCulture));
            

            return stringBuilder.ToString();
        }
    }
}