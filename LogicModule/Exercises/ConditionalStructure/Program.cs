using System;
using System.Globalization;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseConditional1(); //Just change the call to one of the other methods for try a different.
        }

        static void ExerciseConditional1()
        {
            Console.WriteLine("Digite um número:");
            int number = int.Parse(Console.ReadLine());

            if (number >= 0)
                Console.WriteLine($"{number} não é negativo;");
            else Console.WriteLine($"{number} é negativo");
        }


        static void ExerciseConditional2()
        {
            Console.WriteLine("Digite um número inteiro para saber se ele é par ou impar:");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine($"{number} é par");
            else Console.WriteLine($"{number} é ímpar");
        }

        static void ExerciseConditional3()
        {
            Console.WriteLine("Digite dois números inteiros para saber se eles são multiplos entre si:");
            string[] vector = Console.ReadLine().Split(' ');
            int number1 = int.Parse(vector[0], CultureInfo.InvariantCulture);
            int number2 = int.Parse(vector[1], CultureInfo.InvariantCulture);

            if (number1 % number2 == 0 || number2 % number1 == 0)
                Console.WriteLine("São multiplos.");
            else Console.WriteLine("Não são multiplos.");
        }

        static void ExerciseConditional4()
        {
            Console.WriteLine("Informe a hora de início do jogo:");
            int initialTime = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a hora de fim do jogo:");
            int finalTime = int.Parse(Console.ReadLine());

            int elapsedTime;

            if (initialTime < finalTime)
                elapsedTime = finalTime - initialTime;
            else elapsedTime = 24 - initialTime + finalTime;

            Console.WriteLine($"O jogo durou {elapsedTime} hora(s).");
        }

        static void ExerciseConditional5()
        {
            Console.WriteLine("Digite o código do item e a sua quantidade:");
            string[] itens = Console.ReadLine().Split(' ');
            int code = int.Parse(itens[0]);
            int amount = int.Parse(itens[1]);
            double total;

            switch (code)
            {
                case 1:
                    total = amount * 4;
                    break;
                case 2:
                    total = amount * 4.5;
                    break;
                case 3:
                    total = amount * 5;
                    break;
                case 4:
                    total = amount * 2;
                    break;
                default:
                    total = amount * 1.5;
                    break;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void ExerciseConditional6()
        {
            Console.WriteLine("Digite um valor:");
            double valueFromUser = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valueFromUser < 0 || valueFromUser > 100)
                Console.WriteLine("Fora de intervalo.");
            else if (valueFromUser <= 25.0)
                Console.WriteLine("Intervalo [0, 25]");

            else if (valueFromUser <= 50.0)
                Console.WriteLine("Intevalo [25, 50]");

            else if (valueFromUser <= 75.0)
                Console.WriteLine("Intevalo [50, 75]");

            else
                Console.WriteLine("Intevalo [75, 100]");
        }

        static void ExerciseConditional7()
        {
            Console.WriteLine("Insira dois valores:");
            string[] vector = Console.ReadLine().Split(" ");

            double xAxis = double.Parse(vector[0], CultureInfo.InvariantCulture);
            double yAxis = double.Parse(vector[1], CultureInfo.InvariantCulture);

            if (xAxis == 0.0 && yAxis == 0.0)
                Console.WriteLine("Origem");
            else if (yAxis == 0.0)
                Console.WriteLine("Eixo X");
            else if (xAxis == 0.0)
                Console.WriteLine("Eixo Y");
            else if (xAxis > 0.0 && yAxis > 0.0)
                Console.WriteLine("Q1");
            else if (xAxis < 0.0 && yAxis > 0.0)
                Console.WriteLine("Q2");
            else if (xAxis < 0.0 && yAxis < 0.0)
                Console.WriteLine("Q3");
            else Console.WriteLine("Q4");

        }

        static void ExerciseConditional8()
        {
            Console.WriteLine("Insira o valor da faixa de renda para calcular o imposto:");
            double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double tax = 0;

            if (income <= 2000.00)
                Console.WriteLine("Isento");

            else if (income <= 3000.00)
            {
                tax = (income - 2000.00) * 0.08;
            }
            else if (income <= 4500.00)
            {
                tax = (income - 3000.00) * 0.18 + 1000.00 * 0.08;
            }
            else if (income > 4500.00)
            {
                tax = (income - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000 * 0.08;
            }
            Console.WriteLine("R$ " + tax.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}