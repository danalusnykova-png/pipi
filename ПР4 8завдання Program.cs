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
            Console.Write("Введіть розмір масиву n: ");
        }
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

        int[] arr = new int[n];
        Random rnd = new Random();

        Console.WriteLine("Початковий масив:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = rnd.Next(1, 100);
            Console.Write(arr[i] + " ");
        }

        int last = arr[n - 1];

        for (int i = n - 1; i > 0; i--)
        {
            arr[i] = arr[i - 1];
        }

        arr[0] = last;

        Console.WriteLine();
        Console.WriteLine("Масив після циклічного зсуву вправо:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
