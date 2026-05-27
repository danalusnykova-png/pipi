using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Практична робота №2");
Console.WriteLine("Завдання 2");
Console.WriteLine("Автор проєкту: Лусникова Даніелла");
Console.WriteLine();

Console.Write("Введіть перше число: ");
string input1 = Console.ReadLine() ?? "";

Console.Write("Введіть друге число: ");
string input2 = Console.ReadLine() ?? "";

if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
{
    Console.Write("Введіть операцію (+, -, *, /): ");
    string operation = Console.ReadLine() ?? "";

    switch (operation)
    {
        case "+":
            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
            break;

        case "-":
            Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
            break;

        case "*":
            Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
            break;

        case "/":
            if (number2 != 0)
            {
                Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
            }
            else
            {
                Console.WriteLine("Помилка: на нуль ділити не можна.");
            }
            break;

        default:
            Console.WriteLine("Помилка: такої операції немає.");
            break;
    }
}
else
{
    Console.WriteLine("Помилка: потрібно ввести числа.");
}

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
Console.ReadKey();
