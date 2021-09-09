using System;

namespace Anikin_csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            if (name == "Вячеслав")
                Console.WriteLine("Привет, " + name);
            else
                Console.WriteLine("Нет такого имени");
            Console.ReadKey();
        }
    }
}