using System.IO;

namespace FileFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Gabriel G. Pace\Documents\temp\file1.txt";
            string targetPath = @"C:\Users\Gabriel G. Pace\Documents\temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                
                string [ ] lines = File.ReadAllLines(sourcePath);
                
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("an Error occured");
                Console.WriteLine(e);
                throw;
            }
        }
    }
}