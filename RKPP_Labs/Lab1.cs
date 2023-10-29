using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKPP_Labs
{
    internal class Lab1
    {
        //В двухмерном массиве целых чисел поменять местами строки,
        //симметричные относительно середины массива(горизонтальной линии).

        public static void Lab1_1()
        {
            int rows = 6;
            int columns = 6;
            int[,] array = new int[columns, rows];

            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(0,10);
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Write("===========\n");
            for (int i = 0; i < rows / 2; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int temp = array[i, j];
                    array[i, j] = array[rows - i - 1, j];
                    array[rows - i - 1, j] = temp;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

        }


        //Составить программу, которая будет вводить строку в переменную String.Удалить из нее все лишние пробелы, оставив между
        //словами не более одного. Результат поместить в новую строку.
        public static void Lab1_2()
        {
            Console.WriteLine("Введите строку");
            string? tmp =  Console.ReadLine();
            if (String.IsNullOrEmpty(tmp))
            {
                Console.WriteLine("Недопустимые исходны значения");
                return;
            }

            var words =  tmp.Trim().Split(' ');
            foreach (var item in words)
            {
                if (item.Length > 0) { Console.Write(item + " "); }
            }
        }
        //Задан текст. Определить, содержит ли он цифры
        public static void Lab1_3()
        {

            Console.WriteLine("Введите текст.");
            StringBuilder sb = new StringBuilder();

            string text = "";


           

            while (true)
            {       
                string? tmp = Console.ReadLine();
                if (string.IsNullOrEmpty(tmp))
                {
                    break;
                }
                sb.Append(tmp);
            }
            text = sb.ToString();
            if (String.IsNullOrEmpty(text))
            {
                Console.WriteLine("Недопустимые исходны значения");
                return;
            }

            foreach (var ch in text)
            {
                if (Char.IsDigit(ch))
                {
                    Console.WriteLine("В тексте есть цифры");
                    return;
                }
            }
            Console.WriteLine("В тексте нет цифр");
        }
    }
}
