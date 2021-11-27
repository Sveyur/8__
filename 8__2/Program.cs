using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _8__2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\Users\Sveta\source\repos\8__\8__2\bin\Debug\new papka";
            string path2 = @"C:\Users\Sveta\source\repos\8__\8__2\bin\Debug\new papka\txt.txt";
            Random random = new Random();
            StreamWriter sw = new StreamWriter(path2, false);

            if (!Directory.Exists(path1))
            {
                Directory.CreateDirectory(path1);
            }
            if (!File.Exists(path2))
            {
                File.Create(path2);
            }
            for (int a = 0; a < 10; a++)
            {
                sw.WriteLine("{0}", random.Next(0, 10));
            }
            sw.Close();
            StreamReader sr = new StreamReader(path2);
            string s;
            int summ = 0;
            while ((s = sr.ReadLine()) != null)
            {
                summ += Convert.ToInt32(s);
                Console.WriteLine(s);
            }
            Console.WriteLine("Сумма чисел = " + summ);
            Console.ReadKey();

        }

    }
}


