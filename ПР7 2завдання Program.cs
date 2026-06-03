using System;
using System.Text;

namespace Praktychna7_Task2
{
    class WordStack
    {
        private string[] words;
        private int top;

        public WordStack(int size)
        {
            words = new string[size];
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == words.Length - 1;
        }

        public void Push(string word)
        {
            if (IsFull())
            {
                Console.WriteLine("Стек переповнений. Неможливо додати слово.");
            }
            else
            {
                top++;
                words[top] = word;
                Console.WriteLine("Додано у стек слово: " + word);
            }
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Стек порожній. Неможливо вилучити слово.");
                return "";
            }
            else
            {
                string word = words[top];
                top--;
                return word;
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
                Console.WriteLine("Слова у стеку:");

                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Практична 7. Завдання 2";

            Console.WriteLine("Автор проєкту: Лусникова Даніелла");
            Console.WriteLine("Практична 7");
            Console.WriteLine("Завдання 2. Реалізація стеку для слів");
            Console.WriteLine();

            WordStack stack = new WordStack(5);

            stack.Push("Cybersecurity");
            stack.Push("Data");
            stack.Push("Network");

            Console.WriteLine();
            stack.PrintStack();

            Console.WriteLine();
            string deletedWord = stack.Pop();
            Console.WriteLine("Вилучене слово зі стеку: " + deletedWord);

            Console.WriteLine();
            stack.PrintStack();

            Console.ReadKey();
        }
    }
}
