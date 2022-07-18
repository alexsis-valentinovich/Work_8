using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//3.    Вручную подготовьте текстовый файл с фрагментом текста. Напишите программу, которая выводит статистику по файлу -
//количество символов, строк и слов в тексте.
namespace Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            string str2 = "";
            string str3 = "";
            string str4 = "";
            int k = 0;
            int kStr = 1;
            int posStr = 0;
            string path = @"C:\Учеба\Учеба_задания\Visual Studio\Зад 8\Work_8\Part_3\Unit_Part_8.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                str = sr.ReadToEnd();
                posStr = str.LastIndexOf("\n");
                while (posStr >= 0)
                {
                    str2 = str.Remove(posStr);
                    posStr = str2.LastIndexOf("\n");
                    kStr++;
                }
                Console.WriteLine("Кол-во строк = {0}шт.", kStr);
            }
            str3 = str.Replace("\r\n", "");
            str3 = str3.Replace(" ", "");
            int dlina = str3.Length;
            Console.WriteLine("Кол-во символов = {0}шт.", dlina);
            str4 = str.Replace("\r\n", " ");
            string[] strArr = str4.Split();
            foreach (string s in strArr)
            {
                k++;
            }
            Console.WriteLine("Кол-во слов ={0}шт.", k);
            Console.WriteLine();
            Console.WriteLine("Иследуемая фраза:");
            Console.Write(str);
            Console.ReadKey();
        }
    }
}
