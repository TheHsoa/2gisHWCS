using System;

//Лекция 2, слайд 15
//Заполнить массив длиной N случайными числами. Ввести с консоли число A. Вывести Yes, если число A есть в массиве, No - в противном случае.
namespace L2_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов в массиве: ");
            var n = Convert.ToInt32(Console.ReadLine());

            var arr = new int[n];
            var rand = new Random(Guid.NewGuid().GetHashCode());

            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(0, 10);
            }

            Console.WriteLine("Введите число: ");
            var number = Convert.ToInt32(Console.ReadLine());

            if (Array.IndexOf(arr, number) == -1) Console.WriteLine("No");
            else Console.WriteLine("Yes");

            Console.ReadKey();
        }
    }
}
