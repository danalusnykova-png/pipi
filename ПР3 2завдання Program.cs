using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Автор програми: Даніелла Лусникова");

        int n;

        Console.Write("Введіть ціле додатне число n: ");

        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Помилка. Введіть ціле додатне число n: ");
        }

        int sum = 0;

        for (int i = 2; i <= n; i += 2)
        {
            sum += i;
        }

        Console.WriteLine("Сума всіх парних чисел від 1 до " + n + " = " + sum);

        Console.ReadKey();
    }
}
