namespace ExerciseWithoutInterface.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }

        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null; // It's not necessary to declare the nullity in this field, because the associated object will start as null. Anyway, it's here just for didactic methods.
        }
    }
}