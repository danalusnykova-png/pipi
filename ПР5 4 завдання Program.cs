using System;
using System.Text;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Практична робота №5, Завдання 4";

            Console.WriteLine("Автор проєкту: Лусникова Даніелла");
            Console.WriteLine("Завдання 4. Переклад пори року");
            Console.WriteLine();

            Console.Write("Введіть назву пори року українською мовою: ");
            string season = Console.ReadLine();

            string result = TranslateSeason(season);

            Console.WriteLine("Переклад англійською мовою: " + result);

            Console.ReadKey();
        }

        static string TranslateSeason(string season)
        {
            season = season.ToLower();

            switch (season)
            {
                case "зима":
                    return "winter";

                case "весна":
                    return "spring";

                case "літо":
                    return "summer";

                case "осінь":
                    return "autumn";

                default:
                    return "варіант перекладу відсутній";
            }
        }
    }
}
