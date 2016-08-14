using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   
//Лекция 2 слайд 8
//Ввести с консоли N чисел. Вывести сумму, максимальное, минимальное значения, количество четных чисел, произведение нечетных чисел. 
namespace L2_Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var iterOfEven = 0;
            var compOfOdd = 1;
            var max = 0;
            var min = 0;
            var firstIter = true;

            Console.WriteLine("Введите целые числа через Enter. Для завершени ввода введите любую строку отличную от целого числа.");

            while (true)
            {
                try
                {
                    var i = Convert.ToInt32(Console.ReadLine());

                    sum += i;

                    if (i % 2 == 0)
                    {
                        iterOfEven += 1;
                    }
                    else
                    {
                        compOfOdd *= i;
                    }

                    if (firstIter)
                    {
                        firstIter = false;
                        max = i;
                        min = i;
                    }
                    else
                    {
                        if (max < i) max = i;

                        if (min > i) min = i;
                    }
                }
                catch
                {
                    break;
                }                
            }

            if (!firstIter)
            {
                Console.WriteLine($"Сумма: {sum}");
                Console.WriteLine($"Максимальное: {max}");
                Console.WriteLine($"Минимальное: {min}");
                Console.WriteLine($"Количество четных: {iterOfEven}");
                Console.WriteLine($"Произведение нечетных: {compOfOdd}");
            }
            else
            {
                Console.WriteLine("Не было введено ни одного числа");
            }
            Console.ReadKey();
        }
    }
}
