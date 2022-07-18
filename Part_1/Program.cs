using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//1.    Обязательная задача*. Выберите любую папку на своем компьютере, имеющую вложенные директории. Выведите на консоль ее
//содержимое и содержимое всех подкаталогов.
namespace Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Учеба\Учеба_задания\Visual Studio\Зад 8\Work_8\Part_2\";
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (string file in files)
                Console.WriteLine(file);
            Console.ReadKey();
        }
    }
}
