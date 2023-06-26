using System;
using System.Globalization;

namespace StaticMembers
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circle = Circle(radius);
            Console.WriteLine("Circunferência: " + circle.ToString("F2"), CultureInfo.InvariantCulture);
            double volume = Volume(radius);
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));


        }

        static double Circle(double radius)
        {
            return 2.0 * Pi * radius;
        }

        static double Volume(double radius)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(radius, 3);
        }
    }
}