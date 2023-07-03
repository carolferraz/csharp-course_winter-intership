using System.Globalization;

namespace ExerciseMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number to be the rows and columns in the matrix: ");
            string[] vector = Console.ReadLine().Split(' ');
            int lines = int.Parse(vector[0]);
            int columns = int.Parse(vector[1]);

            int[,] matrix = new int[lines, columns];

            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine($"Enter {columns} numbers:");
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Enter a number to search into the matrix:");
            int searchNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == searchNumber)
                    {
                        Console.WriteLine("Position: " + i + "," + j);
                        if (j > 0)
                        Console.WriteLine($"Left: {matrix[i, j-1]}");
                        
                        else if (j < columns - 1)
                        Console.WriteLine($"Right: {matrix[i,j+1]}");
                        
                        else if (i > 0)
                        Console.WriteLine($"Up: {matrix[i-1,j]}");

                        else if (i < lines - 1)
                        Console.WriteLine($"Down: {matrix[i+1,j]}");
                    }
                    
                }
            }
        }
    }
}
