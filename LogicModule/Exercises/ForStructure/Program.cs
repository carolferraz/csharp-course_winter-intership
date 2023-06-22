using System;
using System.Globalization;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseFor7(); //Just change the call to one of the other methods for try a different.
        }
        static void ExerciseFor1()
        {
            Console.WriteLine("Digite um valor:");
            int valueFromUser = int.Parse(Console.ReadLine());

            for (int i = 0; i <= valueFromUser; i++)

            {
                if (valueFromUser < 1 || valueFromUser > 1000)
                {
                    Console.WriteLine("Tente um valor entre 1 e 1000.");
                }
                else if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void ExerciseFor2()
        {
            Console.WriteLine("Digite um valor para determinar a quantidade de números a serem confirmados no intervalo [10, 20]:");
            int numberForLoop = int.Parse(Console.ReadLine());

            int inData = 0;
            int outData = 0;

            for (int i = 0; i < numberForLoop; i++)
            {
                Console.WriteLine("Digite um valor para checagem:");
                int checkedNumber = int.Parse(Console.ReadLine());

                if (checkedNumber >= 10 && checkedNumber <= 20)
                {
                    inData++;
                }
                else
                {
                    outData++;
                }
            }

            Console.WriteLine(inData + " in");
            Console.WriteLine(outData + " out");
        }

        static void ExerciseFor3()
        {
            Console.WriteLine("Digite um valor para determinar o número de testes a seguir:");
            int numberForLoop = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberForLoop; i++)
            {
                Console.WriteLine("Digite três valores:");
                string[] vector = Console.ReadLine().Split(' ');
                double number1 = double.Parse(vector[0], CultureInfo.InvariantCulture);
                double number2 = double.Parse(vector[1], CultureInfo.InvariantCulture);
                double number3 = double.Parse(vector[2], CultureInfo.InvariantCulture);

                //For you remember: a weighted avarage is calculated by the summing of products of each number by its weight, and then dividing by the sum of those weights.

                double avarage = Math.Round(((number1 * 2) + (number2 * 3) + (number3 * 5)) / (2 + 3 + 5));

                Console.WriteLine(avarage.ToString("F1", CultureInfo.InvariantCulture));

            }

        }

        static void ExerciseFor4()
        {
            Console.WriteLine("Digite um valor para determinar o número de testes a seguir:");
            int numberForLoop = int.Parse(Console.ReadLine());
            double result = 0;

            for (int i = 0; i < numberForLoop; i++)
            {
                Console.WriteLine("Digite dois valores:");
                string[] vector = Console.ReadLine().Split(' ');
                double number1 = double.Parse(vector[0], CultureInfo.InvariantCulture);
                double number2 = double.Parse(vector[1], CultureInfo.InvariantCulture);

                if (number2 == 0)
                {
                    Console.WriteLine("Divisão impossível");
                }
                else result = number1 / number2;
                Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));
            }

        }

        static void ExerciseFor5()
        {
            //This code will use the number given from the user, and this will be used to be the finish for the loop. We will iterate starting with 1, and at every loop add 1 to the predecessorNumber. So, that will multiply for the result and be save in that variable in every loop. In this way, we will have all the predecessors numbers. 

            Console.WriteLine("Digite um valor para determinar seu fatorial:");
            int factorialNumber = int.Parse(Console.ReadLine());
            int result = 1;

            for (int predecessorNumber = 1; predecessorNumber <= factorialNumber; predecessorNumber++)
            {
                result *= predecessorNumber;
            }

            Console.WriteLine(result);
        }

        static void ExerciseFor6()
        {
            Console.WriteLine("Digite um valor para determinar seus divisores:");
            int number = int.Parse(Console.ReadLine());

            for (int dividerNumber = 1; dividerNumber <= number; dividerNumber++)
            {
                if (number % dividerNumber == 0)
                    Console.WriteLine(dividerNumber);
            }

        }

        static void ExerciseFor7()
        {
            Console.WriteLine("Digite um valor");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int sqrt = (int)Math.Pow(i, 2);
                int cube = (int)Math.Pow(i, 3);

                Console.WriteLine(i + " " + sqrt + " " + cube);
            }
        }
    }
}