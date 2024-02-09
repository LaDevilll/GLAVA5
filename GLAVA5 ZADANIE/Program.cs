using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLAVA5_ZADANIE
{
    class DoubleFactorialDemo
    {
        // Метод для вычисления двойного факториала без рекурсии
        static int CalculateDoubleFactorialIterative(int n)
        {
            int result = 1;
            // Уменьшаем n на 2 до 1 или 2 в зависимости от четности/нечетности
            while (n > 0)
            {
                result *= n;
                n -= 2;
            }

            return result;
        }

        // Метод для вычисления двойного факториала с рекурсией
        static int CalculateDoubleFactorialRecursive(int n)
        {
            // Базовый случай: если n <= 1, возвращаем 1
            if (n <= 1)
            {
                return 1;
            }
            // Рекурсивный вызов для уменьшения n на 2.
            return n * CalculateDoubleFactorialRecursive(n - 2);
        }

        static void Main()
        {
            // Примеры вызова методов
            int number1 = 6;
            int number2 = 5;
            // Вычисление двойного факториала без рекурсии:
            int result1 = CalculateDoubleFactorialIterative(number1);
            Console.WriteLine($"{number1}!! (без рекурсии) = {result1}");
            // Вычисление двойного факториала с рекурсией:
            int result2 = CalculateDoubleFactorialRecursive(number2);
            Console.WriteLine($"{number2}!! (с рекурсией) = {result2}");
        }
    }
}
