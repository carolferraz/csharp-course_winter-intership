using System;
using System.Globalization;

namespace triangleAreaWithPOO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Triangle x, y;

            x = new Triangle();
            y = new Triangle();


            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (x.A + x.B + x.C) / 2;

            double triangleXArea = Math.Sqrt(pX * (pX - x.A) * (pX - x.B) * (pX - x.C));


            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pY = (y.A + y.B + y.C) / 2;

            double triangleYArea = Math.Sqrt(pY * (pY - y.A) * (pY - y.B) * (pY - y.C));


            Console.WriteLine("Área de X: " + triangleXArea.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("Área de Y: " + triangleYArea.ToString("F4"), CultureInfo.InvariantCulture);

            if (triangleXArea > triangleYArea)
            {
                Console.WriteLine("Maior área: X");
            }
            else Console.WriteLine("Maior área: Y");
        }
    }
}