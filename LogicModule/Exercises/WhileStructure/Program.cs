using System;
using System.Globalization;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseWhile1(); //Just change the call to one of the other methods for try a different.
        }
        static void ExerciseWhile1()
        {
            Console.WriteLine("Digite sua senha:");
            int password = int.Parse(Console.ReadLine());


            while (password != 2002)
            {
                Console.WriteLine("Senha inválida");
                password = int.Parse(Console.ReadLine());
                // Never iniciate a while without a line to finish the repeat action.
            }
            Console.WriteLine("Acesso Permitido");

        }


        static void ExerciseWhile2()
        {
            Console.WriteLine("Digite duas coordenadas para X e Y, respectivamente:");
            string[] vector = Console.ReadLine().Split(" ");
            int x = int.Parse(vector[0]);
            int y = int.Parse(vector[0]);

            while (x != 0 && y != 0)
            {
                if (x > 0.0 && y > 0.0)
                    Console.WriteLine("primeiro");
                else if (x < 0.0 && y > 0.0)
                {
                    Console.WriteLine("segundo");
                    // vector = Console.ReadLine().Split(" ");
                    // x = int.Parse(vector[0]);
                    // y = int.Parse(vector[0]);
                }
                else if (x < 0.0 && y < 0.0)
                    Console.WriteLine("terceiro");
                else Console.WriteLine("quarto");

                vector = Console.ReadLine().Split(" ");
                x = int.Parse(vector[0]);
                y = int.Parse(vector[0]);

                //We could use the code between the line 198 and 200 in any if statement (as well as 191 to 193), but in these way we can save a few lines of repeted code. 

                //The important thing is to have this part inside the while, as a form to return.  
            }
        }

        static void ExerciseWhile3()
        {

            int alcohol = 0;
            int gasoline = 0;
            int diesel = 0;

            bool keepGoing = true;
            while (keepGoing)
            {

                //Here I had a problem to Parse the string to int, so I researched for a way to solve this and discover to TryParse method. This work in a diferent way: we have two variables, the "var result" is a bool that will return true, if the Parse work well, or false if don't. The out "var valueFromUser" is the return from the Parse, if it's is all right we will have the data Parsed, if don't the data will return with the quotes from a string.

                Console.WriteLine("Qual o combustível de sua preferência? Digite 1.Álcool 2.Gasolina 3.Diesel 4.Para encerrar");
                var result = int.TryParse(Console.ReadLine(), out var valueFromUser);

                if (valueFromUser == 1)
                {
                    alcohol++;
                }
                else if (valueFromUser == 2)
                {
                    gasoline++;
                }
                else if (valueFromUser == 3)
                {
                    diesel++;
                }
                else if (valueFromUser == 4)
                {
                    keepGoing = false;
                }

            }

            Console.WriteLine("Muito obrigado!");
            Console.WriteLine("Álcool: " + alcohol);
            Console.WriteLine("Gasolina: " + gasoline);
            Console.WriteLine("Diesel: " + diesel);

        }
    }
}