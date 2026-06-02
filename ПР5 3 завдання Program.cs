using System;
using System.Text;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Практична робота №5, Завдання 3";

            Console.WriteLine("Автор проєкту: Лусникова Даніелла");
            Console.WriteLine("Завдання 3. Перевірка кратності без параметрів");
            Console.WriteLine();

            CheckMultiple();

            Console.ReadKey();
        }

        static void CheckMultiple()
        {
            int number1, number2;

            Console.Write("Введіть перше ціле число: ");
            bool correctNumber1 = int.TryParse(Console.ReadLine(), out number1);

            Console.Write("Введіть друге ціле число: ");
            bool correctNumber2 = int.TryParse(Console.ReadLine(), out number2);

            if (correctNumber1 && correctNumber2 && number2 != 0)
            {
                if (number1 % number2 == 0)
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
        }
    }
}
