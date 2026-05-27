using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Практична робота №2");
Console.WriteLine("Додаткове завдання 15");
Console.WriteLine("Автор проєкту: Лусникова Даніелла");
Console.WriteLine();

Console.Write("Введіть вартість покупки, грн: ");
string input = Console.ReadLine() ?? "";

if (double.TryParse(input, out double price))
{
    if (price > 0)
    {
        double finalPrice;

        if (price > 1000)
        {
            finalPrice = price - price * 0.10;
            Console.WriteLine("Надано знижку 10%.");
        }
        else
        {
            finalPrice = price;
            Console.WriteLine("Знижка не надається.");
        }

        Console.WriteLine($"Початкова вартість покупки: {price} грн");
        Console.WriteLine($"Кінцева вартість покупки: {finalPrice} грн");
    }
    else
    {
        Console.WriteLine("Помилка: вартість покупки має бути додатним числом.");
    }
}
else
{
    Console.WriteLine("Помилка: потрібно ввести числове значення.");
}

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
Console.ReadKey();
