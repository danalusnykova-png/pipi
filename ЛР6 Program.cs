using System;
using System.Text;

namespace Lab6Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Лабораторна робота №6, Лусникова Даніелла";

            Console.WriteLine("Автор проєкту: Лусникова Даніелла");
            Console.WriteLine("Лабораторна робота №6");
            Console.WriteLine("Варіант 2");
            Console.WriteLine("Бінарний пошук у масиві символів");
            Console.WriteLine();

            int size;

            Console.Write("Введіть розмір масиву: ");
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Помилка. Введіть додатне ціле число: ");
            }

            char[] array = new char[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ReadChar(i + 1);
            }

            Console.WriteLine();
            Console.WriteLine("Початковий масив:");
            PrintArray(array);

            Console.WriteLine();
            Console.Write("Введіть символ для пошуку: ");
            char searchValue = ReadChar();

            Console.WriteLine();
            Console.WriteLine("Пошук у невідсортованому масиві методом Array.IndexOf:");

            int index = Array.IndexOf(array, searchValue);

            if (index >= 0)
            {
                Console.WriteLine($"Символ '{searchValue}' знайдено. Індекс: {index}");
            }
            else
            {
                Console.WriteLine($"Символ '{searchValue}' не знайдено.");
            }

            Console.WriteLine();
            Console.WriteLine($"Символи, більші за '{searchValue}':");

            char[] biggerElements = Array.FindAll(array, x => x > searchValue);

            if (biggerElements.Length > 0)
            {
                PrintArray(biggerElements);
            }
            else
            {
                Console.WriteLine("Таких символів немає.");
            }

            Array.Sort(array);

            Console.WriteLine();
            Console.WriteLine("Відсортований масив:");
            PrintArray(array);

            Console.WriteLine();
            Console.WriteLine("Бінарний пошук у відсортованому масиві:");

            int binaryIndex = BinarySearch(array, searchValue);

            if (binaryIndex >= 0)
            {
                Console.WriteLine($"Символ '{searchValue}' знайдено. Індекс: {binaryIndex}");
            }
            else
            {
                Console.WriteLine($"Символ '{searchValue}' не знайдено.");
            }

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

        static char ReadChar()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    return input[0];
                }

                Console.Write("Помилка: потрібно ввести хоча б один символ: ");
            }
        }

        static int BinarySearch(char[] array, char value)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (array[middle] == value)
                {
                    return middle;
                }

                if (array[middle] < value)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1;
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
