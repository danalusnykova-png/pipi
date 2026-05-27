using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Практична робота №2");
Console.WriteLine("Завдання 1");
Console.WriteLine("Автор проєкту: Лусникова Даніелла");
Console.WriteLine();

Console.Write("Введіть ціле число: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    if (number % 2 == 0)
    {
        Console.WriteLine("Число є парним.");
    }
    else
    {
        Console.WriteLine("Число є непарним.");
    }

    if (number > 0)
    {
        Console.WriteLine("Число є додатним.");
    }
    else if (number < 0)
    {
        Console.WriteLine("Число є від’ємним.");
    }
    else
    {
        Console.WriteLine("Число дорівнює нулю.");
    }
}
else
{
    Console.WriteLine("Помилка: потрібно ввести саме ціле число.");
}

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
Console.ReadKey();
