using System.Globalization;
using ExerciseAbstractMethods.Entities;
using ExerciseAbstractMethods.Entities.Enums;

namespace ExerciseAbstractMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int numberOfShapes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfShapes; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or circle (r/c)? ");
                char shape = char.Parse(Console.ReadLine());

                if (shape == 'r' || shape == 'R')
                {
                    Console.Write("Color (Black/Blue/Red): ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());

                    Shape rectangle = new Rectangle(width, height, color);

                    shapeList.Add(rectangle);
                }
                else if (shape == 'c' || shape == 'C')
                {
                    Console.Write("Color (Black/Blue/Red): ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    Shape circle = new Circle(radius, color);

                    shapeList.Add(circle);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape item in shapeList)
            {
                Console.WriteLine(item.Area().ToString("F2"), CultureInfo.InvariantCulture);
            }

        }
    }
}