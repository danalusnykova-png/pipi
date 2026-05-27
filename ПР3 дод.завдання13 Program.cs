using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Автор програми: Даніелла Лусникова");

        string answer;

        do
        {
            int n;
            int choice;

            Console.Write("Введіть кількість парних чисел N: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Помилка. Введіть ціле додатне число N: ");
            }

            Console.WriteLine("Оберіть дію:");
            Console.WriteLine("1 - сума");
            Console.WriteLine("2 - добуток");
            Console.WriteLine("3 - середнє арифметичне");

            Console.Write("Ваш вибір: ");
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.Write("Помилка. Введіть 1, 2 або 3: ");
            }

            int sum = 0;
            long product = 1;

            for (int i = 1; i <= n; i++)
            {
                int evenNumber = i * 2;
                sum += evenNumber;
                product *= evenNumber;
            }

            if (choice == 1)
            {
                Console.WriteLine("Сума перших " + n + " парних чисел = " + sum);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Добуток перших " + n + " парних чисел = " + product);
            }
            else
            {
                double average = (double)sum / n;
                Console.WriteLine("Середнє арифметичне перших " + n + " парних чисел = " + average);
            }

            Console.Write("Бажаєте продовжити? Y - так, N - ні: ");
            answer = Console.ReadLine();

        } while (answer == "Y" || answer == "y");

        Console.WriteLine("Роботу програми завершено.");

        Console.ReadKey();
    }
}
