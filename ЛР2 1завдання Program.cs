using System;
using System.Text;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Лабораторна робота №2, Лусникова Даніелла";

            double x = -0.9;
            double y = 0;
            double y1 = Math.Asin(x);

            Console.WriteLine("Автор проєкту: Лусникова Даніелла");
            Console.WriteLine("Лабораторна робота №2");
            Console.WriteLine("Базовий рівень, варіант 10");
            Console.WriteLine();

            Console.WriteLine("*************************************************************");
            Console.Write("y = ");

            for (int n = 1; n <= 20; n++)
            {
                double member = ((2 * n - 1) * Math.Pow(x, 2 * n + 1)) / (2 * n * (2 * n + 1));
                y += member;

                Console.Write($"{member:0.00000}");

                if (n < 20)
                {
                    Console.Write(" + ");
                }
            }

            Console.WriteLine($" = {y:0.00000}");
            Console.WriteLine("*************************************************************");

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y:0.00000}");
            Console.WriteLine($"y1 = {y1:0.00000}");

            Console.ReadKey();
        }
    }
}
