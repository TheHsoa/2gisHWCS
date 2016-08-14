using System;

//Лекция 2, слайд 14
//Заполнить 2 матрицы размерности NxN случайными числами. Вывести на консоль. Сложить 2 матрицы. Вывести результат.
namespace L2_Z3
{
    class Program
    {
        public static void WriteArray(int[,] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов в массиве: ");

            var n = Convert.ToInt32(Console.ReadLine());
            var arr1 = new int[n, n];
            var arr2 = new int[n, n];
            var sumArr = new int[n, n];
            var rand = new Random(Guid.NewGuid().GetHashCode());

            for(int i = 0; i < n; i++)
                for(int j = 0; j < n; j++)
                {
                    arr1[i, j] = rand.Next(0, 100);
                    arr2[i, j] = rand.Next(0, 100);
                    sumArr[i, j] = arr1[i, j] + arr2[i, j];
                }

            Console.WriteLine("Первый массив:");
            WriteArray(arr1, n);

            Console.WriteLine("Второй массив:");
            WriteArray(arr2, n);

            Console.WriteLine("Результирующая сумма двух массивов:");
            WriteArray(sumArr, n);

            Console.ReadKey();
        }
    }
}
