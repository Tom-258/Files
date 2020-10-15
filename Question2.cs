using System;
using System.Collections.Generic;
using System.IO;

namespace Files
{
    public class Question2
    {
        public int numberRandom;
        public int limit;
        public string path;
        public string name;


        public void Write()
        {
            var myFile = File.AppendText(Path.Combine(path, name));
            var randomNumber = new Random();
            for (int i = 0; i < numberRandom; i++)
            {
                myFile.WriteLine(randomNumber.Next(1,limit));
            }
            myFile.Close();
        }

        public void Sort()
        {
            var fileContents = File.ReadAllText(path);
            var myFile = File.AppendText(Path.Combine(path,
                "sorted.txt"));
            var myList = new List<int>();
            for (var i = 0; i < fileContents.Length-1; i++)
            {
                myList.Add(fileContents[i]);
            }
            BubbleSort(myList);
            
            foreach (var number in myList)
            {
                myFile.WriteLine(number);
            }
            myFile.Close();

            
        }
        private void BubbleSort(List<int> MyList)
        {
            for (var j = 0; j < MyList.Count; j++)
            {
                for (var i = 0; i <= MyList.Count - 2; i++)
                {
                    if (MyList[i] <= MyList[i + 1]) continue;
                    var temp = MyList[i];
                    MyList[i] = MyList[i + 1];
                    MyList[i + 1] = temp;
                }
            }
        }
    }
}