using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//2.    Обязательная задача*. Программно создайте текстовый файл и запишите в него 10 случайных чисел. Затем программно откройте
//созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
namespace Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            string path = @"C:\Учеба\Учеба_задания\Visual Studio\Зад 8\Work_8\Part_2\Unit_8.txt";
            Random random = new Random();
            Console.Write("Запись: ");
            using (StreamWriter sw = new StreamWriter(path, false))
                for (int i = 0; i < 10; i++)
                {
                    int r = random.Next(-20, 20);
                    sw.WriteLine(r);
                    Console.Write("{0}, ", r);
                }
            Console.WriteLine();
            Console.Write("Чтение: ");
            using (StreamReader sr = new StreamReader(path))
                for (int j = 0; j < 10; j++)
                {
                    int r = Convert.ToInt32(sr.ReadLine());
                    Console.Write("{0}, ", r);
                    s += r;
                }
            Console.WriteLine();
            Console.WriteLine("Сумма = {0}", s);
            Console.ReadKey();
        }
    }
}
