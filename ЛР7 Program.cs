using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_Firms
{
    class Firm
    {
        public string Name;
        public string City;
        public string Activity;
        public int Year;

        public Firm(string name, string city, string activity, int year)
        {
            Name = name;
            City = city;
            Activity = activity;
            Year = year;
        }

        public void Show()
        {
            Console.WriteLine("Назва: " + Name);
            Console.WriteLine("Місто: " + City);
            Console.WriteLine("Діяльність: " + Activity);
            Console.WriteLine("Рік заснування: " + Year);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            List<Firm> firms = new List<Firm>();

            firms.Add(new Firm("SoftLine", "Київ", "розробка програм", 2015));
            firms.Add(new Firm("TechMarket", "Львів", "продаж техніки", 2018));
            firms.Add(new Firm("CyberSafe", "Одеса", "кібербезпека", 2020));

            int choice = 0;

            while (choice != 6)
            {
                Console.WriteLine();
                Console.WriteLine("Лабораторна робота №7");
                Console.WriteLine("Автор: Лусникова Даніелла");
                Console.WriteLine("Варіант 10 - список фірм");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. Додати нову фірму");
                Console.WriteLine("2. Вивести список фірм");
                Console.WriteLine("3. Вилучити фірму зі списку");
                Console.WriteLine("4. Знайти фірму за назвою");
                Console.WriteLine("5. Сортувати список фірм");
                Console.WriteLine("6. Вихід");
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
                    SortFirms(firms);
                }
                else if (choice == 6)
                {
                    Console.WriteLine("Роботу програми завершено.");
                }
                else
                {
                    Console.WriteLine("Такого пункту меню немає.");
                }
            }
        }

        static void AddFirm(List<Firm> firms)
        {
            Console.Write("Введіть назву фірми: ");
            string name = Console.ReadLine();

            Console.Write("Введіть місто: ");
            string city = Console.ReadLine();

            Console.Write("Введіть вид діяльності: ");
            string activity = Console.ReadLine();

            Console.Write("Введіть рік заснування: ");
            int year;

            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.Write("Помилка. Введіть рік числом: ");
            }

            Firm newFirm = new Firm(name, city, activity, year);
            firms.Add(newFirm);

            Console.WriteLine("Фірму додано до списку.");
        }

        static void ShowFirms(List<Firm> firms)
        {
            if (firms.Count == 0)
            {
                Console.WriteLine("Список фірм порожній.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Список фірм:");

                for (int i = 0; i < firms.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Фірма №" + (i + 1));
                    firms[i].Show();
                }

                Console.WriteLine();
                Console.WriteLine("Загальна кількість фірм: " + firms.Count);
            }
        }

        static void RemoveFirm(List<Firm> firms)
        {
            Console.Write("Введіть назву фірми для вилучення: ");
            string name = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < firms.Count; i++)
            {
                if (firms[i].Name == name)
                {
                    firms.RemoveAt(i);
                    found = true;
                    Console.WriteLine("Фірму вилучено зі списку.");
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Фірму з такою назвою не знайдено.");
            }
        }

        static void SearchFirm(List<Firm> firms)
        {
            Console.Write("Введіть назву фірми для пошуку: ");
            string name = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < firms.Count; i++)
            {
                if (firms[i].Name == name)
                {
                    Console.WriteLine();
                    Console.WriteLine("Фірму знайдено:");
                    firms[i].Show();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Фірму з такою назвою не знайдено.");
            }
        }

        static void SortFirms(List<Firm> firms)
        {
            for (int i = 0; i < firms.Count - 1; i++)
            {
                for (int j = i + 1; j < firms.Count; j++)
                {
                    if (firms[i].Name.CompareTo(firms[j].Name) > 0)
                    {
                        Firm temp = firms[i];
                        firms[i] = firms[j];
                        firms[j] = temp;
                    }
                }
            }

            Console.WriteLine("Список фірм відсортовано за назвою.");
        }
    }
}