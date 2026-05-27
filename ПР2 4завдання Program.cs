using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Практична робота №2");
Console.WriteLine("Завдання 4");
Console.WriteLine("Автор проєкту: Лусникова Даніелла");
Console.WriteLine();

Console.Write("Введіть час у 24-годинному форматі (наприклад 18:00): ");
string input = Console.ReadLine() ?? "";

string[] parts = input.Split(':');

if (parts.Length == 2 &&
    int.TryParse(parts[0], out int hours) &&
    int.TryParse(parts[1], out int minutes))
{
    if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
    {
        string period;
        int hours12;

        if (hours == 0)
        {
            hours12 = 12;
            period = "AM";
        }
        else if (hours < 12)
        {
            hours12 = hours;
            period = "AM";
        }
        else if (hours == 12)
        {
            hours12 = 12;
            period = "PM";
        }
        else
        {
            hours12 = hours - 12;
            period = "PM";
        }

        Console.WriteLine($"{hours:D2}:{minutes:D2} = {hours12}:{minutes:D2} {period}");
    }
    else
    {
        Console.WriteLine("Помилка: години мають бути від 0 до 23, а хвилини від 0 до 59.");
    }
}
else
{
    Console.WriteLine("Помилка: введіть час у форматі години:хвилини, наприклад 18:00.");
}

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
Console.ReadKey();
