using System;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Практична робота №5, Завдання 2";

            Console.WriteLine("Автор проєкту: Лусникова Даніелла");
            Console.WriteLine("Завдання 2. Перевірка кратності двох чисел");
            Console.WriteLine();

            int number1, number2;

            Console.Write("Введіть перше ціле число: ");
            bool correctNumber1 = int.TryParse(Console.ReadLine(), out number1);

            Console.Write("Введіть друге ціле число: ");
            bool correctNumber2 = int.TryParse(Console.ReadLine(), out number2);

            if (correctNumber1 && correctNumber2 && number2 != 0)
            {
                if (IsMultiple(number1, number2))
                {
                    Console.WriteLine($"{number1} є кратним {number2}");
                }
                else
                {
                    Console.WriteLine($"{number1} не є кратним {number2}");
                }
            }
            else
            {
                Console.WriteLine("Помилка: введено некоректні дані або друге число дорівнює нулю.");
            }

            Console.ReadKey();
        }

        static bool IsMultiple(int a, int b)
        {
            return a % b == 0;
        }
    }
}
