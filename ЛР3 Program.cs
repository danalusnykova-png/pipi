using System;
using System.Text;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Лабораторна робота №3, Лусникова Даніелла";

            Console.WriteLine("Автор проєкту: Лусникова Даніелла");
            Console.WriteLine("Лабораторна робота №3");
            Console.WriteLine("Варіант 10");
            Console.WriteLine();

            int[,] matrix = new int[10, 10];
            Random rnd = new Random();

            Console.WriteLine("Початкова матриця:");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = rnd.Next(-20, 31);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Кількість нульових елементів у кожному стовпці:");

            for (int j = 0; j < 10; j++)
            {
                int countZero = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (matrix[i, j] == 0)
                    {
                        countZero++;
                    }
                }

                Console.WriteLine("Стовпець " + (j + 1) + ": " + countZero);
            }

            Console.ReadKey();
        }
    }
}
