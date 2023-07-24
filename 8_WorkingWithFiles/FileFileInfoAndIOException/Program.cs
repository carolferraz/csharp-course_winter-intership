using System.IO;

namespace FileFileInfoAndIOException
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\caroline.ferraz\Documents\CSharp_CursoCompleto\8_WorkingWithFiles\FileFileInfoAndIOException\file1.txt";
            string copyPath = @"C:\Users\caroline.ferraz\Documents\CSharp_CursoCompleto\8_WorkingWithFiles\FileFileInfoAndIOException\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                // fileInfo.CopyTo(copyPath);
                string[] readLines = File.ReadAllLines(sourcePath);
                foreach (string line in readLines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Something went wrong! " + ex.Message);
            }

        }
    }
}