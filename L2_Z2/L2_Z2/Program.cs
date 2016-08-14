using System;

//Лекция 2, слайд 12
//Заполнить с консоли массив из N элементов. Отсортировать. Вывести результат. N - задается с консоли
namespace L2_Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов в массиве: ");
            var n = Convert.ToInt32(Console.ReadLine());

            var arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i}-й элемент массива:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);

            Console.WriteLine("Результирующий отсортированный массив:");
            for (int i = 0; i < n; i++)
            {                
                Console.Write($"{arr[i]} ");
            }

            Console.ReadKey();
        }
    }
}
