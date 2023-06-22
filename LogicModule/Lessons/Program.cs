using System;
using System.Globalization;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            CondicionalStructure();
        }

        static void DataOutput()
        {
            string product1 = "Computador";
            string product2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{product1}, cujo preço é R${preco1:F2}");
            Console.WriteLine($"{product2}, cujo preco é R$ {preco2:F2}");
            Console.WriteLine("");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine("");
            Console.WriteLine($"Medida com oito casas decimais{medida:F8}");
            Console.WriteLine($"Arredondando (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariante cultura: " + medida.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }

        static void CalculateBaskara()
        {
            double a = 1.0, b = -3.0, c = -4;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine($"O valor de delta é: {delta}, de x1 é: {x1} e de x2 é: {x2}");

        }

        static void DataInput()
        {
            //    Console.WriteLine("Digite um número inteiro (positivo ou negativo):");
            //    int number = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Digite uma única letra:");
            //    char character = char.Parse(Console.ReadLine());

            //    Console.WriteLine("Digite um número real, com quantas casas decimais quiser:");
            //    double real = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  

            //    Console.WriteLine("Digite seu primeiro nome, seu gênero (usando F, M, ou N para neutro), sua idade, sua altura. Escreva tudo separado por espaço antes de digitar enter.");
            //     string[] vector = Console.ReadLine().Split(' ');
            //     string name = vector[0];
            //     char gender = char.Parse(vector[1]);
            //     int age = int.Parse(vector[2]);
            //     double height = double.Parse(vector[3], CultureInfo.InvariantCulture);


            // // Console.WriteLine(number);
            // // Console.WriteLine(character);
            // // Console.WriteLine(real.ToString("F2", CultureInfo.InvariantCulture));
            // Console.WriteLine(name);
            // Console.WriteLine(gender);
            // Console.WriteLine(age);
            // Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Entre com seu nome completo:");
            string completeName = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int rooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double product = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite seu primeiro nome, idade e altura (na mesma linha)");

            string[] vector = Console.ReadLine().Split(' ');
            string name = vector[0];
            int age = int.Parse(vector[1]);
            double height = double.Parse(vector[2], CultureInfo.InvariantCulture);



            Console.WriteLine(completeName);
            Console.WriteLine(rooms);
            Console.WriteLine(product.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));

        }

        static void CondicionalStructure()
        {
            Console.WriteLine("Digite a hora atual, em números inteiros:");
            int timeNow = int.Parse(Console.ReadLine());

            if (timeNow < 12)
                Console.WriteLine("Bom dia!");
            else if (timeNow < 18)

                Console.WriteLine("Boa tarde!");
            else
                Console.WriteLine("Boa noite!");



        }
    }
}
