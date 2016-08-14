using System;

//Лекция 2, слайд 15
/*Калькулятор. С консоли вводится левый операнд, операция, правый операнд. Выводится результат операции над операндами. Реализовать как минимум 4 операции, 
 обработку ошибок (деление на 0 и др).*/
namespace L2_HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3) {
                var a = 0.0;
                var b = 0.0;
                var operation = '@';
                try
                {
                    a = Convert.ToDouble(args[0]);
                }
                catch(FormatException e)
                {
                    Console.WriteLine("Неверный формат строки: первый аргумент - число");
                    Environment.Exit(0);
                }
                try
                {
                    operation = Convert.ToChar(args[1]);                    
                }
                catch(FormatException e)
                {
                    Console.WriteLine("Неверный формат строки: второй аргумент - символ операции: сложение(\"+\"), вычитание(\"-\"), деление(\"/\"), умножение(\"*\")");
                    Environment.Exit(0);
                }
                try
                {
                    b = Convert.ToDouble(args[2]);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Неверный формат строки: третий аргумент - число");
                    Environment.Exit(0);
                }

                switch (operation)
                {
                    case '+':
                        Console.WriteLine(a + b);
                        break;
                    case '-':
                        Console.WriteLine(a - b);
                        break;
                    case '*':                        
                        Console.WriteLine(a * b);
                        break;
                    case '/':
                        if (b == 0)
                        {
                            Console.WriteLine("Ошибка: деление на ноль");
                        }
                        else
                        {
                            Console.WriteLine(a / b);
                        }
                        break;
                    default:
                        Console.WriteLine("Неизвестная операция. Доступные операции: сложение(\"+\"), вычитание(\"-\"), деление(\"/\"), умножение(\"*\")");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Неверное количество аргументов.");
            }
        }
    }
}
