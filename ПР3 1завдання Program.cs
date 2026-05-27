using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Автор програми: Даніелла Лусникова");

        int n;

        Console.Write("Введіть кількість повторень N: ");

        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Помилка. Введіть ціле додатне число N: ");
        }

        Console.WriteLine("\nРезультат:");

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Лусникова Даніелла");
        }

        Console.ReadKey();
    }
}