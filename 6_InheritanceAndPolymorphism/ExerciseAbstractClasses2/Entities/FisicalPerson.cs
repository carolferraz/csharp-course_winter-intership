using System.Globalization;

namespace ExerciseAbstractClasses2
{
    class FisicalPerson : TaxPayment
    {
        public double HealthExpenses { get; set; }

        public FisicalPerson()
        {
        }

        public FisicalPerson(string name, double annualIncome, double healthExpenses) : base(name, annualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double Tax()
        {
            if (AnnualIncome >= 20000.00)
            {
                return (AnnualIncome * 0.25) - (HealthExpenses * 0.5);
            }
            else
            {
                return (AnnualIncome * 0.15) - HealthExpenses; 
            }
        }
        public override string ToString()
        {
            return Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}