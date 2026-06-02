using System;
using System.Text;

namespace SamRob1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Самостійна робота №1, Лусникова Даніелла";

            Console.WriteLine("Автор проєкту: Лусникова Даніелла");
            Console.WriteLine("Самостійна робота №1");
            Console.WriteLine("Варіант 10");
            Console.WriteLine();

            Console.Write("Введіть символьний рядок: ");
            string text = Console.ReadLine();

            Console.Write("Введіть загальну довжину рядка: ");
            int length;

            if (!int.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Помилка: потрібно ввести ціле число.");
                Console.ReadKey();
                return;
            }

            Console.Write("Введіть символ для доповнення: ");
            string symbolInput = Console.ReadLine();

            if (string.IsNullOrEmpty(symbolInput))
            {
                Console.WriteLine("Помилка: символ для доповнення не введено.");
                Console.ReadKey();
                return;
            }

            char symbol = symbolInput[0];

            if (length <= text.Length)
            {
                Console.WriteLine("Задана довжина менша або дорівнює довжині початкового рядка.");
                Console.WriteLine("Рядок не змінено: " + text);
            }
            else
            {
                string result = text.PadLeft(length, symbol);

                Console.WriteLine();
                Console.WriteLine("Початковий рядок: " + text);
                Console.WriteLine("Задана довжина: " + length);
                Console.WriteLine("Символ для доповнення: " + symbol);
                Console.WriteLine("Результат: " + result);
            }

            Console.ReadKey();
        }
    }
}
