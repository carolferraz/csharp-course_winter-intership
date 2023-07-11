using System.Globalization;

namespace ExerciseAbstractClasses2
{
    class LegalPerson : TaxPayment
    {
        public int NumberOfEmployees { get; set; }

        public LegalPerson()
        {
        }

        public LegalPerson(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }

        public override string ToString()
        {
            return Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}