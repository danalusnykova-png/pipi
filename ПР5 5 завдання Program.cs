using System;
using System.Text;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Практична робота №5, Завдання 5";

            Console.WriteLine("Автор проєкту: Лусникова Даніелла");
            Console.WriteLine("Завдання 5. Обмін значеннями двох чисел");
            Console.WriteLine();

            double number1, number2;

            Console.Write("Введіть перше число: ");
            bool correctNumber1 = double.TryParse(Console.ReadLine(), out number1);

            Console.Write("Введіть друге число: ");
            bool correctNumber2 = double.TryParse(Console.ReadLine(), out number2);

            if (correctNumber1 && correctNumber2)
            {
                Console.WriteLine();
                Console.WriteLine($"До обміну: number1 = {number1}, number2 = {number2}");

                Swap(ref number1, ref number2);

                Console.WriteLine($"Після обміну: number1 = {number1}, number2 = {number2}");
            }
            else
            {
                Console.WriteLine("Помилка: потрібно ввести числові значення.");
            }

            Console.ReadKey();
        }

        static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
    }
}
