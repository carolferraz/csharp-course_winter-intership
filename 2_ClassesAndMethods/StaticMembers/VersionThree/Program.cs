using System;
using System.Globalization;

namespace StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
        // Using the static method in the class we can access all their methods and fields without need to instatiate the class.
        
            Console.Write("Entre com o valor do raio: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circle = Calculator.Circle(radius);
            Console.WriteLine("Circunferência: " + circle.ToString("F2"), CultureInfo.InvariantCulture);
            double volume = Calculator.Volume(radius);
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}