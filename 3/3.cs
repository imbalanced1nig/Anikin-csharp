using System;

namespace Anikin_csharp
{
    class Program
    {
        public static void foo(int[] arr)
        {
            Console.WriteLine("\nКратные трём:");
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 3 == 0)
                {
                    Console.WriteLine("arr[" + i + "]=" + arr[i]);
                }
        }

        public static void Main(string[] args)
        {
            // Задать с клавиатуры число элементов массива
            Console.WriteLine("Введите число элементов массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            // Объявим одномерный массив Data с n-элементами 
            var Data = new int[n];
            for (int i = 1; i <= n; i++)
                Data[i - 1] = i;
            foo(Data);
            Console.ReadKey();
        }
    }
}
