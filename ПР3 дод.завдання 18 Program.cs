using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Автор програми: Даніелла Лусникова");
        Console.WriteLine("Таблиця значень функції y = -2,4x^2 + 5x - 3");
        Console.WriteLine();

        Console.WriteLine("x\t\ty");

        for (double x = -2; x <= 2.0001; x += 0.5)
        {
            double y = -2.4 * x * x + 5 * x - 3;

            Console.WriteLine($"{x:F1}\t\t{y:F2}");
        }

        Console.ReadKey();
    }
}
