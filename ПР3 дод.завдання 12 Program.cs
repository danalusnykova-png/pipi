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

        Console.Write("Введіть ціле число B, більше за A: ");
        while (!int.TryParse(Console.ReadLine(), out b) || b <= a)
        {
            Console.Write("Помилка. Введіть ціле число B, яке більше за A: ");
        }

        int count = 0;

        Console.WriteLine("Цілі числа між A і B у порядку убування:");

        for (int i = b - 1; i > a; i--)
        {
            Console.WriteLine(i);
            count++;
        }

        Console.WriteLine("Кількість чисел = " + count);

        Console.ReadKey();
    }
}
