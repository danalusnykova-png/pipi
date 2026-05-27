using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Автор програми: Даніелла Лусникова");

        double x;
        int k;

        Console.Write("Введіть число x: ");
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Помилка. Введіть дійсне число x: ");
        }

        Console.Write("Введіть ціле додатне число k: ");
        while (!int.TryParse(Console.ReadLine(), out k) || k <= 0)
        {
            Console.Write("Помилка. Введіть ціле додатне число k: ");
        }

        double result = 1;

        for (int i = 1; i <= k; i++)
        {
            result *= x;
        }

        Console.WriteLine(x + "^" + k + " = " + result);

        Console.ReadKey();
    }
}
