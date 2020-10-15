using System;
using System.IO;

namespace Files
{
    public class Question1
    {
        private StreamWriter myFile;

        public Question1(string path, string fileName)
        {
            var fullPath = path +@"\"+ fileName;
            var exists = File.Exists(Path.GetFullPath(fullPath));
            Console.WriteLine("File exists: {0}",exists);
            myFile = File.AppendText(Path.Combine(path, fileName));
            Append();

        }

        private void Append()
        {
            
            while (true)
            {
                Console.WriteLine("Word:\n");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;
                myFile.WriteLine(input);
            } 
            myFile.Close();
        }
    }
}