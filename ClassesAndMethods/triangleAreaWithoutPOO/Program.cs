using System;
using System.Globalization;

namespace triangleAreaWithoutPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            triangleArea();
        }

        static void triangleArea()
        {
            Console.WriteLine("Entre com as medidas do triângulo X:");
            double aX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double bX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double cX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (aX + bX + cX) / 2;  

            double triangleXArea = Math.Sqrt(pX*(pX - aX)*(pX-bX)*(pX-cX));


            Console.WriteLine("Entre com as medidas do triângulo Y:");
            double aY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double bY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double cY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pY = (aY + bY + cY) / 2;  

            double triangleYArea = Math.Sqrt(pY*(pY - aY)*(pY-bY)*(pY-cY));


            Console.WriteLine("Área de X: " + triangleXArea.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("Área de Y: " + triangleYArea.ToString("F4"), CultureInfo.InvariantCulture);

            if(triangleXArea > triangleYArea)
            {
                Console.WriteLine("Maior área: X");
        } else Console.WriteLine("Maior área: Y");
        }
    }
}