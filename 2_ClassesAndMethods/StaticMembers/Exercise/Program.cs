using System;
using System.Globalization;

namespace StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            //For you remember: here we are using the static method in the class, so we don't need to instatiate the class to have access to their methods and fields. 

            Console.Write("Qual é a cotação do dólar?");
            Converter.dollarQuotation = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            Converter.dollarPurchase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais: " + Converter.ConverterWithTax().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}