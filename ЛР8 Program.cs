using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_Dictionary_Firms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Dictionary<string, string> firms = new Dictionary<string, string>();

            firms.Add("1001", "SoftLine, місячний дохід: 120000 грн");
            firms.Add("1002", "TechMarket, місячний дохід: 95000 грн");
            firms.Add("1003", "CyberSafe, місячний дохід: 150000 грн");

            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine();
                Console.WriteLine("Лабораторна робота №8");
                Console.WriteLine("Автор: Лусникова Даніелла");
                Console.WriteLine("Варіант 10 - словник фірм");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. Додати новий елемент до словника");
                Console.WriteLine("2. Вивести всі елементи словника");
                Console.WriteLine("3. Вилучити елемент за ключем");
                Console.WriteLine("4. Знайти елемент за ключем");
                Console.WriteLine("5. Вихід");
                Console.Write("Оберіть пункт меню: ");

                bool ok = int.TryParse(Console.ReadLine(), out choice);

                if (!ok)
                {
                    Console.WriteLine("Помилка введення. Введіть число.");
                    continue;
                }

                if (choice == 1)
                {
                    AddFirm(firms);
                }
                else if (choice == 2)
                {
                    ShowFirms(firms);
                }
                else if (choice == 3)
                {
                    RemoveFirm(firms);
                }
                else if (choice == 4)
                {
                    SearchFirm(firms);
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Роботу програми завершено.");
                }
                else
                {
                    Console.WriteLine("Такого пункту меню немає.");
                }
            }
        }

        static void AddFirm(Dictionary<string, string> firms)
        {
            Console.Write("Введіть код платника податку: ");
            string code = Console.ReadLine();

            if (firms.ContainsKey(code))
            {
                Console.WriteLine("Елемент з таким ключем уже існує.");
            }
            else
            {
                Console.Write("Введіть назву фірми: ");
                string name = Console.ReadLine();

                Console.Write("Введіть місячний дохід: ");
                string income = Console.ReadLine();

                string value = name + ", місячний дохід: " + income + " грн";

                firms.Add(code, value);

                Console.WriteLine("Новий елемент додано до словника.");
            }
        }

        static void ShowFirms(Dictionary<string, string> firms)
        {
            if (firms.Count == 0)
            {
                Console.WriteLine("Словник порожній.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Словник фірм:");

                foreach (KeyValuePair<string, string> item in firms)
                {
                    Console.WriteLine(item.Key + " - " + item.Value);
                }

                Console.WriteLine();
                Console.WriteLine("Загальна кількість елементів у словнику: " + firms.Count);
            }
        }

        static void RemoveFirm(Dictionary<string, string> firms)
        {
            Console.Write("Введіть код платника податку для вилучення: ");
            string code = Console.ReadLine();

            if (firms.ContainsKey(code))
            {
                firms.Remove(code);
                Console.WriteLine("Елемент вилучено зі словника.");
            }
            else
            {
                Console.WriteLine("Елемент з таким ключем не знайдено.");
            }
        }

        static void SearchFirm(Dictionary<string, string> firms)
        {
            Console.Write("Введіть код платника податку для пошуку: ");
            string code = Console.ReadLine();

            if (firms.ContainsKey(code))
            {
                Console.WriteLine("Елемент знайдено:");
                Console.WriteLine(code + " - " + firms[code]);
            }
            else
            {
                Console.WriteLine("Елемент з таким ключем не знайдено.");
            }
        }
    }
}
