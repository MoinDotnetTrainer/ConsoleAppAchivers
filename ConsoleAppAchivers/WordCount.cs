using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    class WordCount
    {
        public int GetWords(string Filename)
        {
            int lenth = 0;
            using (StreamReader reader = new StreamReader(Filename))
            {
                string str = reader.ReadToEnd();  // total words
                lenth = str.Length;
                Task.Delay(10000).Wait();
            }
            return lenth; // final lenth of the file    
        }

        public void Exe()
        {
            string filename = "C:\\Users\\m.a.khaja.moinuddin\\OneDrive - Accenture\\desktop\\Myfile.txt";
            int finalwords = GetWords(filename);


            Console.WriteLine("Task 1");
            Console.WriteLine("Task 2");
            Console.WriteLine("Task 3");
            Console.WriteLine($"The lenth of the file is {finalwords}"); // final 

            Console.WriteLine("Task 4");
            Console.WriteLine("Task 52");
            Console.WriteLine("Task 6");

        }

        public async Task<int> GetWords1(string Filename)
        {
            int lenth = 0;
            using (StreamReader reader = new StreamReader(Filename))
            {
                string str = await reader.ReadToEndAsync();  // total words
                lenth = str.Length;
                Task.Delay(10000).Wait();
            }
            return lenth; // final lenth of the file    
        }

        public async void Exe1()
        {
            string filename = "C:\\Users\\m.a.khaja.moinuddin\\OneDrive - Accenture\\desktop\\Myfile.txt";
            Task<int> res = GetWords1(filename);


            Console.WriteLine("Task 1");
            Console.WriteLine("Task 2");
            Console.WriteLine("Task 3");
            int finalres = await res;
            Console.WriteLine($"The lenth of the file is {finalres}"); // final 

            Console.WriteLine("Task 4");
            Console.WriteLine("Task 52");
            Console.WriteLine("Task 6");

        }
    }
}
