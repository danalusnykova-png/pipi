using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Автор програми: Даніелла Лусникова");

        int n;
        double x;
        double sum = 0;

        Console.Write("Введіть ціле додатне число n: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Помилка. Введіть ціле додатне число n: ");
        }

        Console.Write("Введіть число x: ");
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Помилка. Введіть число x: ");
        }

        for (int i = 1; i <= n; i++)
        {
            sum += i * i * x;
        }

        Console.WriteLine("Результат S = " + sum);

        Console.ReadKey();
    }
}
