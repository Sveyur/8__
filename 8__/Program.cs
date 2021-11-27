using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _8__
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Sveta\source\repos\8__\8__";
            string[] dirs = Directory.GetDirectories(path);
            foreach (string d in dirs)
            {
                Console.WriteLine("\nКаталог: {0}", d);
                string[] dir = Directory.GetDirectories(d);
                foreach (string dv in dir)
                {
                    Console.WriteLine("    Подкаталог: {0}", dv);
                    string[] di = Directory.GetFiles(dv);
                    foreach (string ssss in di)
                    {
                        Console.WriteLine("          Файл подкаталога: " + ssss);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Файлы:");
            string[] files = Directory.GetFiles(path);
            foreach (string d in files)
            {
                Console.WriteLine(d);
            }

            Console.ReadKey();




        }
    }
}