using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Автор програми: Даніелла Лусникова");

        int number;
        int count = 0;
        int min = 0;
        int max = 0;

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

            if (count == 0)
            {
                min = number;
                max = number;
            }
            else
            {
                if (number < min)
                {
                    min = number;
                }

                if (number > max)
                {
                    max = number;
                }
            }

            count++;
        }

        Console.WriteLine("Кількість введених чисел = " + count);

        if (count > 0)
        {
            Console.WriteLine("Мінімальний елемент = " + min);
            Console.WriteLine("Максимальний елемент = " + max);
        }
        else
        {
            Console.WriteLine("Числа не були введені.");
        }

        Console.ReadKey();
    }
}