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
        string answer;

        do
        {
            Console.Write("Введіть число: ");

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Помилка. Введіть ціле число: ");
            }

            sum += number;

            if (number > 0)
            {
                positiveCount++;
            }
            else if (number < 0)
            {
                negativeCount++;
            }

            Console.Write("Бажаєте продовжити введення? Yes або No: ");
            answer = Console.ReadLine();

        } while (answer == "Yes" || answer == "yes");

        Console.WriteLine("Сума введених чисел = " + sum);
        Console.WriteLine("Кількість додатних чисел = " + positiveCount);
        Console.WriteLine("Кількість від'ємних чисел = " + negativeCount);

        Console.ReadKey();
    }
}
