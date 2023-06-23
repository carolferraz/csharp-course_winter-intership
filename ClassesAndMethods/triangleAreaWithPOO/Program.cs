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

            double triangleX = x.Area();


            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double triangleY = y.Area();


            Console.WriteLine("Área de X: " + triangleX.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("Área de Y: " + triangleY.ToString("F4"), CultureInfo.InvariantCulture);

            if (triangleX > triangleY)
            {
                Console.WriteLine("Maior área: X");
            }
            else Console.WriteLine("Maior área: Y");
        }
    }
}