using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Автор програми: Даніелла Лусникова");

        int number;
        long product = 1;
        int count = 0;

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

            product *= number;
            count++;
        }

        if (count > 0)
        {
            Console.WriteLine("Добуток введених чисел = " + product);
        }
        else
        {
            Console.WriteLine("Числа не були введені.");
        }

        Console.ReadKey();
    }
}
