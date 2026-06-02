using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Автор проєкту: Лусникова Даніелла");

        int n;
        do
        {
            Console.Write("Введіть розмір масиву n (не менше 3): ");
        }
        while (!int.TryParse(Console.ReadLine(), out n) || n < 3);

        int[] arr = new int[n];
        Random rnd = new Random();

        Console.WriteLine("Масив:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = rnd.Next(-20, 21);
            Console.Write(arr[i] + " ");
        }

        int count = 0;

        for (int i = 1; i < n - 1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                count++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Кількість елементів, більших за обох сусідів: " + count);
    }
}