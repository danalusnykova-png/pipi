using System;
using System.Text;

namespace Practice6_Rectangle
{
    class Rectangle
    {
        private double sideA;
        private double sideB;

        public Rectangle()
        {
            sideA = 1;
            sideB = 1;
        }

        public Rectangle(double a, double b)
        {
            sideA = a;
            sideB = b;
        }

        public void SetSides(double a, double b)
        {
            sideA = a;
            sideB = b;
        }

        public double GetSideA()
        {
            return sideA;
        }

        public double GetSideB()
        {
            return sideB;
        }

        public double GetPerimeter()
        {
            return 2 * (sideA + sideB);
        }

        public double GetArea()
        {
            return sideA * sideB;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Сторона A: {sideA}");
            Console.WriteLine($"Сторона B: {sideB}");
            Console.WriteLine($"Периметр: {GetPerimeter()}");
            Console.WriteLine($"Площа: {GetArea()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Практична 6, Лусникова Даніелла";

            Console.WriteLine("Автор проєкту: Лусникова Даніелла");
            Console.WriteLine("Практична 6");
            Console.WriteLine("Завдання 1. Клас Rectangle");
            Console.WriteLine();

            Rectangle rectangle = new Rectangle(5, 8);

            Console.WriteLine("Інформація про один прямокутник:");
            rectangle.PrintInfo();

            Console.WriteLine();

            Rectangle[] rectangles = new Rectangle[3];

            rectangles[0] = new Rectangle(4, 6);
            rectangles[1] = new Rectangle(7, 9);
            rectangles[2] = new Rectangle(10, 12);

            Console.WriteLine("Інформація про масив прямокутників:");

            for (int i = 0; i < rectangles.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Прямокутник №{i + 1}");
                rectangles[i].PrintInfo();
            }

            double sumA = 0;
            double sumB = 0;

            for (int i = 0; i < rectangles.Length; i++)
            {
                sumA += rectangles[i].GetSideA();
                sumB += rectangles[i].GetSideB();
            }

            double averageA = sumA / rectangles.Length;
            double averageB = sumB / rectangles.Length;

            Rectangle averageRectangle = new Rectangle(averageA, averageB);

            Console.WriteLine();
            Console.WriteLine("Прямокутник із середніми значеннями сторін:");
            averageRectangle.PrintInfo();

            Console.ReadKey();
        }
    }
}
