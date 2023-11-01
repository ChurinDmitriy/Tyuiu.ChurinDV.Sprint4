using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChurinDV.Sprint4.Task3.V25.Lib;


namespace Tyuiu.ChurinDV.Sprint4.Task3.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Чурин Дмитрий Владимирович | ИСТНб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 2 до 7.              *");
            Console.WriteLine("* Найдите произведение элементов в четвертом столбце массива.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив: ");

            int[,] mas2 = new int[5, 5] { { 7, 3, 5, 3, 6 }, { 4, 6, 2, 5, 7 }, { 2, 3, 3, 3, 5 }, { 2, 7, 7, 6, 2 }, { 6, 6, 4, 3, 6 } };

            int rows = mas2.GetUpperBound(0) + 1;
            int colums = mas2.Length / rows;

            DataService ds = new DataService();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{mas2[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mas2);

            Console.WriteLine("Произведение элементов в четвертом столбце массива = " + ds.Calculate(mas2));

            Console.ReadLine();

        }
    }
}
