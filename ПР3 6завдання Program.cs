using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Автор програми: Даніелла Лусникова");

        int a, b;

        Console.Write("Введіть ціле число A: ");
        while (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Помилка. Введіть ціле число A: ");
        }

        Console.Write("Введіть ціле число B: ");
        while (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Помилка. Введіть ціле число B: ");
        }

        int start, end;

        if (a > b)
        {
            start = a - 1;
            end = b + 1;
        }
        else
        {
            start = b - 1;
            end = a + 1;
        }

        int count = 0;

        Console.WriteLine("Числа між A і B у порядку убування:");

        for (int i = start; i >= end; i--)
        {
            Console.WriteLine(i);
            count++;
        }

        Console.WriteLine("Кількість чисел = " + count);

        Console.ReadKey();
    }
}
