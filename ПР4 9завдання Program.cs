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
            Console.Write("Введіть розмір квадратної матриці N: ");
        }
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 1);

        int[,] matrix = new int[n, n];
        Random rnd = new Random();

        Console.WriteLine("Початкова матриця:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = rnd.Next(-20, 21);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < n; i++)
        {
            int temp = matrix[i, 0];
            matrix[i, 0] = matrix[i, n - 1];
            matrix[i, n - 1] = temp;
        }

        Console.WriteLine("Матриця після обміну першого і останнього стовпців:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}