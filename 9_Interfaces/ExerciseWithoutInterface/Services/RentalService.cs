using ExerciseWithoutInterface.Entities;

namespace ExerciseWithoutInterface.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxServices _brazilTaxServices = new BrazilTaxServices();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;

        }
        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment;
            if (duration.TotalHours <= 12) basicPayment = Math.Ceiling(duration.TotalHours) * PricePerHour;
            else basicPayment = Math.Ceiling(duration.TotalDays) * PricePerDay;

            double tax = _brazilTaxServices.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);

        }
    }
}