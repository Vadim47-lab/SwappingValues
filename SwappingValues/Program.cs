using System;

namespace SwappingValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            string dataСhange;

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            surname = Console.ReadLine();

            Console.WriteLine("\n Начальные неверные данные - имя: " + name + " и фамилия: " + surname);

            dataСhange = name;
            name = surname;
            surname = dataСhange;

            Console.WriteLine("\n Окончательные правильные данные - имя: " + name + " и фамилия: " + surname);
        }
    }
}
