using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Автор програми: Даніелла Лусникова");
        Console.WriteLine("Таблиця значень функції y = |x - 3| + |x + 2|");
        Console.WriteLine();

        Console.WriteLine("x\t\ty");

        for (double x = -5; x <= 5.0001; x += 0.4)
        {
            double y = Math.Abs(x - 3) + Math.Abs(x + 2);

            Console.WriteLine($"{x:F1}\t\t{y:F2}");
        }

        Console.ReadKey();
    }
}
