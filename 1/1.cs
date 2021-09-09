using System;

namespace Anikin_csharp
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите число больше 7: ");
            var value = Console.ReadLine();
            if (int.Parse(value) >= 7)
                Console.WriteLine("Привет");
            else Console.WriteLine("Число меньше 7");
        }
    }
}