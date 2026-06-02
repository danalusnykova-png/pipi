using System;
using System.Text;

namespace Lab5Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Лабораторна робота №5, Лусникова Даніелла";

            Console.WriteLine("Автор проєкту: Лусникова Даніелла");
            Console.WriteLine("Лабораторна робота №5");
            Console.WriteLine("Варіант 10");
            Console.WriteLine("Сортування масиву символів методом вставки за зростанням");
            Console.WriteLine();

            char[] symbols = new char[10];

            for (int i = 0; i < symbols.Length; i++)
            {
                symbols[i] = ReadChar(i + 1);
            }

            Console.WriteLine();
            Console.WriteLine("Початковий масив:");
            PrintArray(symbols);

            InsertionSort(symbols);

            Console.WriteLine();
            Console.WriteLine("Відсортований масив:");
            PrintArray(symbols);

            Console.ReadKey();
        }

        static char ReadChar(int number)
        {
            while (true)
            {
                Console.Write($"Введіть символ {number}: ");
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    return input[0];
                }

                Console.WriteLine("Помилка: потрібно ввести хоча б один символ.");
            }
        }

        static void InsertionSort(char[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                char key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }
        }

        static void PrintArray(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
