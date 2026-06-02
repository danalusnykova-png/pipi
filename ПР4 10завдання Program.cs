using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Автор проєкту: Лусникова Даніелла");

        string[] logins = { "Alice", "Bob", "Carl" };
        string[] passwords = { "1111", "2222", "3333" };
        string[] rights = { "rx", "w", "rw" };

        Console.Write("Введіть логін: ");
        string login = Console.ReadLine();

        Console.Write("Введіть пароль: ");
        string password = Console.ReadLine();

        Console.Write("Введіть тип доступу (r - читання, w - запис, x - виконання): ");
        string access = Console.ReadLine();

        bool found = false;

        for (int i = 0; i < logins.Length; i++)
        {
            if (login == logins[i] && password == passwords[i])
            {
                found = true;

                if (rights[i].Contains(access))
                {
                    Console.WriteLine("Доступ дозволено.");
                }
                else
                {
                    Console.WriteLine("Доступ заборонено.");
                }

                Console.WriteLine("Користувач: " + logins[i]);
                Console.WriteLine("Права доступу: " + rights[i]);
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Неправильний логін або пароль. Доступ заборонено.");
        }
    }
}
