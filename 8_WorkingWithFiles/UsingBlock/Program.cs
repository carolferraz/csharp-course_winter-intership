using System.IO;

namespace UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\caroline.ferraz\Documents\CSharp_CursoCompleto\8_WorkingWithFiles\UsingBlock\file1.txt";
            try
            {
                // using (FileStream fs = new FileStream(path, FileMode.Open))
                // {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
                // }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}