using System;

//Лекция 2, слайд 15
//Заполнить матрицу NxM случайными числами. Из каждой строки выбрать минимальный элемент, занести его в массив. Отсортировать полученный массив и вывести его значения в обратном порядке.
namespace L2_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк в массиве: ");
            var n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число столбцов в массиве: ");
            var m = Convert.ToInt32(Console.ReadLine());

            var arr = new int[n, m];
            var arrMin = new int[n];
            var rand = new Random(Guid.NewGuid().GetHashCode());

            for (int i = 0; i < n; i++) {
                arr[i, 0] = rand.Next(0, 100);
                arrMin[i] = arr[i, 0];
                for (int j = 1; j < m; j++)
                {
                    arr[i, j] = rand.Next(0, 100);
                    if (arrMin[i] > arr[i, j]) arrMin[i] = arr[i, j];
                }
            }

            Array.Sort(arrMin);

            Console.WriteLine("Результирующий массив: ");
            for(int i = n - 1; i >= 0; i--)
            {
                Console.Write($"{arrMin[i]} ");
            }

            Console.ReadKey();          
        }
    }
}
