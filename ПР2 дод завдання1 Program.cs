using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Практична робота №2");
Console.WriteLine("Додаткове завдання 14");
Console.WriteLine("Автор проєкту: Лусникова Даніелла");
Console.WriteLine();

Console.Write("Введіть перший катет a: ");
string inputA = Console.ReadLine() ?? "";

Console.Write("Введіть другий катет b: ");
string inputB = Console.ReadLine() ?? "";

if (int.TryParse(inputA, out int a) && int.TryParse(inputB, out int b))
{
    if (a > 0 && b > 0 && a <= 1000 && b <= 1000)
    {
        double c = Math.Sqrt(a * a + b * b);

        Console.WriteLine($"Гіпотенуза трикутника c = {c}");
    }
    else
    {
        Console.WriteLine("Помилка: числа мають бути цілими, додатними і не більшими за 1000.");
    }
}
else
{
    Console.WriteLine("Помилка: потрібно ввести цілі числа.");
}

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
Console.ReadKey();
