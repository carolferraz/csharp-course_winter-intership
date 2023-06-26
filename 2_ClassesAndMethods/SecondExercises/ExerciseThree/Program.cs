using System;
using System.Globalization;

namespace ExerciseThree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("Nome do aluno:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            student.GradeOne = double.Parse(Console.ReadLine());
            student.GradeTwo = double.Parse(Console.ReadLine());
            student.GradeThree = double.Parse(Console.ReadLine());

            Console.Write("NOTA FINAL:");
            Console.WriteLine(student.FinalGrade().ToString("F2", CultureInfo.InvariantCulture));

            if (student.Aproved())
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM: " + student.RemainingScore().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS.  :(");

            }


        }
    }
}