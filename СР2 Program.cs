using System;
using System.Text;

namespace SamRob2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Самостійна робота №2, Лусникова Даніелла";

            Console.WriteLine("Автор проєкту: Лусникова Даніелла");
            Console.WriteLine("Самостійна робота №2");
            Console.WriteLine("Варіант 10");
            Console.WriteLine("Визначення порядкового номера дня у році");
            Console.WriteLine();

            int day, month, year;

            Console.Write("Введіть день народження: ");
            bool correctDay = int.TryParse(Console.ReadLine(), out day);

            Console.Write("Введіть місяць народження: ");
            bool correctMonth = int.TryParse(Console.ReadLine(), out month);

            Console.Write("Введіть рік народження: ");
            bool correctYear = int.TryParse(Console.ReadLine(), out year);

            if (!correctDay || !correctMonth || !correctYear)
            {
                Console.WriteLine("Помилка: потрібно вводити тільки цілі числа.");
                Console.ReadKey();
                return;
            }

            if (!IsValidDate(day, month, year))
            {
                Console.WriteLine("Помилка: такої дати не існує.");
                Console.ReadKey();
                return;
            }

            int numberOfDay = GetDayNumber(day, month, year);

            Console.WriteLine();
            Console.WriteLine($"Дата: {day}.{month}.{year}");
            Console.WriteLine($"Порядковий номер дня у році: {numberOfDay}");

            Console.ReadKey();
        }

        static int GetDayNumber(int day, int month, int year)
        {
            int[] daysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (IsLeapYear(year))
            {
                daysInMonths[1] = 29;
            }

            int result = 0;

            for (int i = 0; i < month - 1; i++)
            {
                result += daysInMonths[i];
            }

            result += day;

            return result;
        }

        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        static bool IsValidDate(int day, int month, int year)
        {
            if (year <= 0 || month < 1 || month > 12)
            {
                return false;
            }

            int[] daysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (IsLeapYear(year))
            {
                daysInMonths[1] = 29;
            }

            return day >= 1 && day <= daysInMonths[month - 1];
        }
    }
}
