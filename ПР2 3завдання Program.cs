using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Практична робота №2");
Console.WriteLine("Завдання 3");
Console.WriteLine("Автор проєкту: Лусникова Даніелла");
Console.WriteLine();

Console.Write("Введіть дійсне число A: ");
string input = Console.ReadLine() ?? "";

if (double.TryParse(input, out double A))
{
    double x = (A + 9.32) / 6.42;
    double y;

    if (x > 2 && x < 8)
    {
        y = Math.Exp(x + 1);
    }
    else if (x <= 2 || x > 15)
    {
        y = -3 * x + 8;
    }
    else
    {
        y = Math.Abs(3 * x - 5.5);
    }

    Console.WriteLine($"x = {x}");
    Console.WriteLine($"y = {y}");
}
else
{
    Console.WriteLine("Помилка: потрібно ввести дійсне число.");
}

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
Console.ReadKey();
