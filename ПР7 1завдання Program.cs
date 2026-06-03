using System;
using System.Text;

namespace Praktychna7_Task1
{
    class Stack
    {
        private int[] data;
        private int top;

        public Stack(int size)
        {
            data = new int[size];
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == data.Length - 1;
        }

        public void Push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Стек переповнений. Неможливо додати елемент.");
            }
            else
            {
                top++;
                data[top] = value;
                Console.WriteLine("Додано у стек: " + value);
            }
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Стек порожній. Неможливо вилучити елемент.");
                return 0;
            }
            else
            {
                int value = data[top];
                top--;
                return value;
            }
        }

        public void PrintStack()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Стек порожній.");
            }
            else
            {
                Console.WriteLine("Елементи стеку:");

                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(data[i]);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Практична 7. Завдання 1";

            Console.WriteLine("Автор проєкту: Лусникова Даніелла");
            Console.WriteLine("Практична 7");
            Console.WriteLine("Завдання 1. Реалізація стеку для чисел");
            Console.WriteLine();

            Stack stack = new Stack(5);

            stack.Push(10);
            stack.Push(25);
            stack.Push(40);

            Console.WriteLine();
            stack.PrintStack();

            Console.WriteLine();
            int deletedElement = stack.Pop();
            Console.WriteLine("Вилучений елемент зі стеку: " + deletedElement);

            Console.WriteLine();
            stack.PrintStack();

            Console.ReadKey();
        }
    }
}
