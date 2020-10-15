using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            InitQuestion1();
            InitQuestion2();
            
            
        }

        private static void InitQuestion1()
        {
            var filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            const string fileName = "sentences.txt";
            new Question1(filePath, fileName);
        }

        private static void InitQuestion2()
        {
            var question2 = new Question2 { numberRandom = 15, path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), name = "unsorted.txt" };
            Console.WriteLine("Limit?");
            question2.limit = Convert.ToInt32(Console.ReadLine());
            question2.Write();
            question2.Sort();
        }
    }
}
