namespace ExerciseWithoutInterface.Services
{
    class BrazilTaxService : ITaxService //It's not Inherance, it's an interface realization.
    {
        public double Tax(double amount)
        {
            if (amount <= 100) return amount * 0.2;
            else return amount * 0.15;
        }
    }
}