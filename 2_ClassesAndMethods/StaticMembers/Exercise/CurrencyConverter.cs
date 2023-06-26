namespace StaticMembers {
    class Converter
    {
        public static double dollarQuotation;
        public static double dollarPurchase;
        public static double Iof = 6.0;

        public static double ConverterDollar()
        {
            return dollarQuotation * dollarPurchase;
        }

        public static double ConverterWithTax()
        {
            return ConverterDollar() + (ConverterDollar() * Iof);
        }

    }
}