using System;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Практична робота №5, Завдання 1";

            Console.WriteLine("Автор проєкту: Лусникова Даніелла");
            Console.WriteLine("Завдання 1. Таблиця множення");
            Console.WriteLine();

            int number;

            Console.Write("Введіть число від 0 до 9: ");

            if (int.TryParse(Console.ReadLine(), out number) && number >= 0 && number <= 9)
            {
                PrintMultiplicationTable(number);
            }
            else
            {
                Console.WriteLine("Помилка: потрібно ввести число від 0 до 9.");
            }

            Console.ReadKey();
        }

        static void PrintMultiplicationTable(int number)
        {
            if (number == 0)
            {
                for (int i = 1; i <= 9; i++)
                {
                    Console.WriteLine($"Таблиця множення для {i}:");

                    for (int j = 1; j <= 9; j++)
                    {
                        Console.WriteLine($"{i} * {j} = {i * j}");
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"Таблиця множення для {number}:");

                for (int i = 1; i <= 9; i++)
                {
                    Console.WriteLine($"{number} * {i} = {number * i}");
                }
            }
        }
    }
}
