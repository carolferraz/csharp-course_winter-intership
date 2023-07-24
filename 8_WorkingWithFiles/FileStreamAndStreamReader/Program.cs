using System.IO;

namespace FileStreamAndStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\caroline.ferraz\Documents\CSharp_CursoCompleto\8_WorkingWithFiles\FileStreamAndStreamReader\file1.txt";
            StreamReader streamReader = null;

            try
            {    
                streamReader = File.OpenText(path); //Using the static class File it helps to instatiate the FileStream object and the OpenText method makes this automatic by adding the StreamReader instance with it. So we don't have to instantiate the FileStream and don't have to close ir in the finally block at the end.
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
            }
        }
    }
}