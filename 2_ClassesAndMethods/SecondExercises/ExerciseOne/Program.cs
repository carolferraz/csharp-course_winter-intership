using System;
using System.Formats.Asn1;
using System.Globalization;

namespace ClassesAndMethods
{
    public class ExerciseOne
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle= new Rectangle();
            Console.WriteLine("Entre a largura do retângulo:");
            rectangle.Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre a altura do retângulo:");
            rectangle.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(rectangle.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(rectangle.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(rectangle.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}