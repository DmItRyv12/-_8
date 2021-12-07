using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество цифр в файле");
            int C = Convert.ToInt32(Console.ReadLine());
            int K = 0;
            Random random = new Random();
            string path = "C:\\Users\\asus\\Desktop\\Обучение\\Автоматизация BIM\\Задание 8\\ задача 2.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i <= C; i++)
                {
                    sw.WriteLine(random.Next(0, 50));
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i <= C; i++)
                {
                    K = K + Int32.Parse(sr.ReadLine());
                }
            }
            Console.WriteLine($"Сумма чисел в файле задача 2.txt : {K}");
            Console.ReadKey();
        }
    }
}
