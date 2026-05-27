using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Автор програми: Даніелла Лусникова");

        int number;
        int sum = 0;
        int positiveCount = 0;
        int negativeCount = 0;

        Console.WriteLine("Вводьте числа. Для завершення введіть 0.");

        while (true)
        {
            Console.Write("Введіть число: ");

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Помилка. Введіть ціле число: ");
            }

            if (number == 0)
            {
                break;
            }

            sum += number;

            if (number > 0)
            {
                positiveCount++;
            }
            else
            {
                negativeCount++;
            }
        }

        Console.WriteLine("Сума всіх введених чисел = " + sum);
        Console.WriteLine("Кількість додатних чисел = " + positiveCount);
        Console.WriteLine("Кількість від'ємних чисел = " + negativeCount);

        Console.ReadKey();
    }
}
