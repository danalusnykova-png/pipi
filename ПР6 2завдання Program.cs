using System;
using System.Text;

namespace Practice6_Person
{
    class Person
    {
        private string surname;
        private double height;
        private double weight;
        private int birthYear;

        public Person()
        {
            surname = "Невідомо";
            height = 0;
            weight = 0;
            birthYear = 0;
        }

        public Person(string surname, double height, double weight, int birthYear)
        {
            this.surname = surname;
            this.height = height;
            this.weight = weight;
            this.birthYear = birthYear;
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }

        public int GetAge(int currentYear)
        {
            return currentYear - birthYear;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Прізвище: " + surname);
            Console.WriteLine("Зріст: " + height + " см");
            Console.WriteLine("Вага: " + weight + " кг");
            Console.WriteLine("Рік народження: " + birthYear);
            Console.WriteLine("Вік: " + GetAge(2026) + " років");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Практична робота №6. Завдання 2";

            Console.WriteLine("Автор проєкту: Лусникова Даніелла");
            Console.WriteLine("Практична робота №6");
            Console.WriteLine("Завдання 2. Клас Person");
            Console.WriteLine();

            Person person1 = new Person("Лусникова", 167, 50, 2007);
            Person person2 = new Person("Іваненко", 175, 68, 2006);
            Person person3 = new Person("Петренко", 182, 76, 2005);

            Console.WriteLine("Інформація про першу особу:");
            person1.PrintInfo();

            Console.WriteLine();

            Console.WriteLine("Інформація про другу особу:");
            person2.PrintInfo();

            Console.WriteLine();

            Console.WriteLine("Інформація про третю особу:");
            person3.PrintInfo();

            Console.WriteLine();

            double averageWeight = (person1.Weight + person2.Weight + person3.Weight) / 3;

            Console.WriteLine("Середня вага осіб: " + averageWeight.ToString("0.00") + " кг");

            Console.ReadKey();
        }
    }
}
