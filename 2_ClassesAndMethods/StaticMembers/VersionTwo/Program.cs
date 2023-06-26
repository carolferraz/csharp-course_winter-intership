using System;
using System.Globalization;

namespace StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator= new Calculator();

            Console.Write("Entre com o valor do raio: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circle = calculator.Circle(radius);
            Console.WriteLine("Circunferência: " + circle.ToString("F2"), CultureInfo.InvariantCulture);
            double volume = calculator.Volume(radius);
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}