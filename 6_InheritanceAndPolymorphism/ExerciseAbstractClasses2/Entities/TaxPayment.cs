namespace ExerciseAbstractClasses2
{
    abstract class TaxPayment
    {
        public string Name { get; set;}
        public double AnnualIncome { get; set;}

        public TaxPayment()
        {
        }

        public TaxPayment(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();
    }
}