using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Практична робота №2");
Console.WriteLine("Завдання 5");
Console.WriteLine("Автор проєкту: Лусникова Даніелла");
Console.WriteLine();

Console.Write("Введіть сторону a: ");
string inputA = Console.ReadLine() ?? "";

Console.Write("Введіть сторону b: ");
string inputB = Console.ReadLine() ?? "";

Console.Write("Введіть сторону c: ");
string inputC = Console.ReadLine() ?? "";

if (double.TryParse(inputA, out double a) &&
    double.TryParse(inputB, out double b) &&
    double.TryParse(inputC, out double c))
{
    if (a > 0 && b > 0 && c > 0)
    {
        if (a + b > c && a + c > b && b + c > a)
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("Трикутник з такими сторонами існує.");
            Console.WriteLine($"Півпериметр p = {p}");
            Console.WriteLine($"Площа трикутника S = {S}");
        }
        else
        {
            Console.WriteLine("Трикутник з такими сторонами не існує.");
        }
    }
    else
    {
        Console.WriteLine("Помилка: сторони трикутника мають бути додатними числами.");
    }
}
else
{
    Console.WriteLine("Помилка: потрібно ввести числові значення.");
}

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
Console.ReadKey();