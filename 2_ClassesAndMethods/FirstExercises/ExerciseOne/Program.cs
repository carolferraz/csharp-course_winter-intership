using System;
using System.Globalization;

namespace FirstExercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OlderPerson();
        }

        public static void OlderPerson()
        {
            Person p1 = new Person();
            Person p2 = new Person();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome:");
            p1.Name = Console.ReadLine();
            Console.WriteLine("Idade:");
            p1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine("Nome:");
            p2.Name = Console.ReadLine();
            Console.WriteLine("Idade:");
            p2.Age = int.Parse(Console.ReadLine());


            if (p1.Age > p2.Age)
            {
                Console.WriteLine(p1.Name + " é a pessoa mais velha.");
            }
            else Console.WriteLine(p2.Name + " é a pessoa mais velha.");

        }
    }
}