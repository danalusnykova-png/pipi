using System;
using System.Text;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Лабораторна робота №1, Лусникова Даніелла";

            double x = 12.8;
            double y = -12.5;
            double z = 1.05;
            double a = 100;
            double b = 0.023;

            double m = Math.Sqrt(a / (a + Math.Pow(x, 2)));
            double r = 10 * Math.Exp(-b * x) + Math.Pow(Math.Log(a / x), 2);
            double u = Math.Sqrt(Math.Abs(y + Math.Pow(Math.Tan(z), 2)));
            double i = (x + y) / (5 + Math.Pow(Math.Sin(z), 2));

            Console.WriteLine("Автор проєкту: Лусникова Даніелла");
            Console.WriteLine("Лабораторна робота №1");
            Console.WriteLine("Варіант 10");
            Console.WriteLine();

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"z = {z}");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine();

            Console.WriteLine($"m = {m:0.000}");
            Console.WriteLine($"r = {r:0.000}");
            Console.WriteLine($"u = {u:0.000}");
            Console.WriteLine($"i = {i:0.000}");

            Console.ReadKey();
        }
    }
}
