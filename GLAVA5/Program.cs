using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GLAVA5
{
    internal class Program
    {
        // Статический метод для отображения текста 
        // переданного аргументом методу
        static void Main(string[] args)
        {
            Show("Начинаем вычисления:");
            int m = 5;  // Целочисленные переменные 
            double z = 3, num;  // Действительные переменные 
                                // Вычисление факториала числа 
            Show(m + "!=" + Factorial(m));
            // Число в степени: 
            num = Power(z, m);
            // Отображение сообщения вызовом статического метода 
            Show(z + "  в степени " + m + ":   " + num);
            Console.ReadLine();
        }

        static void Show(string txt)
        {
            Console.WriteLine(txt);
        }

        static int Factorial(int n)
        {
            // Локальная переменная 
            int s = 1;

            // Вычисление произведения 
            for (int k = 1; k <= n; k++)
            {
                // Умножение произведения на число 
                s *= k;
            }
            // Результат метода: 
            return s;
        }
        // Статический метод для возведения числа в степень
        static double Power(double x, int n)
        {
            // Локальная переменная
            double s = 1;
            // Вычисление результата (число в степени)
            for (int k = 1; k <= n; k++)
            {
                // Текущее значение умножается на число
                s *= x;
            }
            // Результат метода 
            return s;
        }
    }




    class OverloadMethDemo
    {
        // Версия статического метода для отображения текста (с одним текстовым аргументом) 
        static void Show(string txt)
        {
            Console.WriteLine("Текст: " + txt);
        }
        // Версия статического метода для отображения целого числа (аргумент метода) 
        static void Show(int num)
        {
            Console.WriteLine("Целое число:  " + num);
        }
        // Версия статического метода для отображения действительного числа (аргумент метода) 
        static void Show(double num)
        {
            Console.WriteLine("Действительное число:  " + num);
        }
        // Версия статического метода для отображения символа (аргумент метода)
        static void Show(char s)
        {
            Console.WriteLine("Символ: " + s);
        }
        // Версия статического метода для отображения числа (первый аргумент) и символа (второй аргумент) 
        static void Show(int num, char s)
        {
            Console.WriteLine("Аргументы {0} и {1}", num, s);
        }

        // Главный метод программы 
        static void Main()
        {
            // Целочисленная переменная 
            int num = 5;
            // Действительная числовая переменная 
            double z = 12.5;
            // Символьная переменная: 
            char symЬ = 'W';
            // Вызываем метод с символьным аргументом 
            Show(symЬ);
            // Вызываем метод с текстовым аргументом: 
            Show("Знакомимся с перегрузкой методов");
            // Вызываем метод с целочисленным аргументом 
            Show(num);
            // Вызываем метод с действительным аргументом 
            Show(z);
            // Вызываем метод с двумя аргументами 
            Show(num, 'Q');
            Console.ReadLine();
        }
    }




    class ArrayToMethDemo
    {
        // Метод для заполнения массива случайными числами: 
        static void fillRand(int[] nums)
        {
            // Объект для генерирования случайных чисел: 
            Random rnd = new Random();
            // Заполнение массива случайными числами: 
            for (int k = 0; k < nums.Length; k++)
            {
                nums[k] = rnd.Next(1, 101);
            }
        }

        // Метод для отображения одномерного целочисленного массива: 
        static void showArray(int[] nums)
        {
            // Перебор элементов массива: 
            for (int k = 0; k < nums.Length; k++)
            {
                // Отображение значения элемента: 
                Console.Write("I  {0}", nums[k]);
                Console.WriteLine("I");
            }
        }

        // Метод для отображения двумерного целочисленного массива: 
        static void showArray(int[,] nums)
        {
            // Перебор строк в массиве: 
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                // Перебор элементов в строке: 
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    // Отображение значения элемента массива: 
                    Console.Write("{0,3}", nums[i, j]);
                }
                // Переход к новой строке: 
                Console.WriteLine();
            }
        }

        // Метод для вычисления наименьшего элемента в массиве: 
        static int findMin(int[] nums)
        {
            // Локальная переменная: 
            int min = nums[0];
            // Поиск наименьшего значения: 
            for (int k = 1; k < nums.Length; k++)
            {
                // Если проверяемый элемент имеет значение, 
                // меньшее текущего значения переменной min: 
                if (nums[k] < min)
                    min = nums[k];
            }
            // Результат метода: 
            return min;
        }

        // Главный метод программы: 
        static void Main()
        {
            // Одномерные массивы: 
            int[] A = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int[] B = new int[5];
            // Двумерный массив: 
            int[,] C = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            // Массив B заполняется случайными числами: 
            fillRand(B);
            Console.WriteLine("Одномерный массив A:");
            // Отображается массив A: 
            showArray(A);
            Console.WriteLine("Одномерный массив B:");
            // Отображается массив B: 
            showArray(B);
            // Поиск наименьшего элемента: 
            int minValue = findMin(B);
            Console.WriteLine("Наименьшее значение: {0}", minValue);
            Console.WriteLine("Двумерный массив C:");
            // Отображается массив C: 
            showArray(C);
        }
    }




    class ArrayFromМethDemo
    {
        // Метод для создания массива с числами Фибоначчи: 
        static int[] fibs(int n)
        {
            // Создается массив: 
            int[] nums = new int[n];
            // Первый элемент массива: 
            nums[0] = 1;
            // Если массив из одного элемента: 
            if (nums.Length == 1)
                return nums;
            // Второй элемент массива: 
            nums[1] = 1;
            // Заполнение элементов массива: 
            for (int k = 2; k < nums.Length; k++)
            {
                // Значение элемента массива равно сумме значений 
                // двух предыдущих элементов: 
                nums[k] = nums[k - 1] + nums[k - 2];
            }
            // Результат метода -  ссылка на массив: 
            return nums;
        }

        // Метод для создания массива со случайными символами: 
        static char[] rands(int n)
        {
            // Объект для генерирования случайных чисел: 
            Random rnd = new Random();
            // Создание массива: 
            char[] symЬs = new char[n];
            // Заполнение массива: 
            for (int k = 0; k < symЬs.Length; k++)
            {
                // Значение элемента -  случайный символ: 
                symЬs[k] = (char)('А' + rnd.Next(26));
            }
            // Результат метода -  ссылка на массив: 
            return symЬs;
        }

        // Метод для создания двумерного массива с нечетными числами: 
        static int[,] odds(int m, int n)
        {
            // Создание двумерного массива: 
            int[,] nums = new int[m, n];
            // Локальная переменная: 
            int val = 1;
            // Перебор строк массива: 
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                // Перебор элементов в строке: 
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    // Значение элемента: 
                    nums[i, j] = val;
                    // Значение для следующего элемента: 
                    val += 2;
                }
            }
            // Результат метода -  ссылка на массив: 
            return nums;
        }

        // Главный метод программы: 
        static void Main()
        {
            // Переменная для целочисленного массива: 
            int[] A;
            // Переменная для символьного массива: 
            char[] B;
            // Переменная для двумерного массива: 
            int[,] C;
            // Создается массив с числами Фибоначчи: 
            A = fibs(10);
            Console.WriteLine("Чиcлa Фибоначчи:");
            // Отображение содержимого массива: 
            foreach (int s in A)
            {
                Console.Write("I  {0}", s);
                Console.WriteLine("I");
            }
            // Создается массив со случайными символами: 
            B = rands(8);
            Console.WriteLine("Cлyчaйныe символы:");
            // Отображение содержимого массива: 
            foreach (char s in B)
            {
                Console.Write("I  {0}", s);
                Console.WriteLine("I");
            }
            // Создается двумерный массив с нечетными числами: 
            C = odds(4, 6);
            Console.WriteLine("Двyмepный массив:");
            // Отображение содержимого двумерного массива: 
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    Console.Write("{0,4)", C[i, j]);
                }
                Console.WriteLine();
            }
        }
    }




    class ArgsDemo
    {
        // Первый метод. Аргумент -  целое число: 
        static void alpha(int n)
        {
            // Проверка значения аргумента: 
            Console.WriteLine("В методе alpha (). На входе: " + n);
            // Попытка изменить значение аргумента: 
            n++;
            // Проверка значения аргумента: 
            Console.WriteLine("В методе alpha (). На выходе: " + n);
        }

        // Второй метод. Аргумент -  ссылка на массив: 
        static void bravo(int[] n)
        {
            // Проверка содержимого массива: 
            Console.WriteLine("В методе bravo (). На входе: " + ArrayToText(n));
            // Перебор элементов массива: 
            for (int k = 0; k < n.Length; k++)
            {
                // Попытка изменить значение элемента массива: 
                n[k]++;
            }
            // Проверка содержимого массива: 
            Console.WriteLine("В методе bravo (). На выходе:  " + ArrayToText(n));
        }

        // Третий метод. Аргумент -  ссылка на массив: 
        static void charlie(int[] n)
        {
            // Проверка содержимого массива: 
            Console.WriteLine("В методе charlie (). На входе:  " + ArrayToText(n));
            // Создается новый массив: 
            int[] m = new int[n.Length];
            // Перебор элементов в массиве: 
            for (int k = 0; k < n.Length; k++)
            {
                // Значение элемента массива: 
                m[k] = n[k] + 1;
            }
            // Попытка присвоить новое значение аргументу: 
            n = m;
            // Проверка содержимого массива: 
            Console.WriteLine("В методе charlie (). На выходе:  " + ArrayToText(n));
        }

        // Метод для преобразования массива в текст: 
        static string ArrayToText(int[] n)
        {
            // Текстовая переменная: 
            string res = "[" + n[0];
            // Перебор элементов массива (кроме начального): 
            for (int k = 1; k < n.Length; k++)
            {
                // Дописывание текста в текстовую переменную: 
                res += ", " + n[k];
            }
            // Дописывание текста в текстовую переменную: 
            res += "] ";
            // Результат метода -  текстовая строка: 
            return res;
        }

        // Главный метод программы: 
        static void Main()
        {
            // Переменная для передачи аргументом методу: 
            int A = 100;
            // Проверка значения переменной: 
            Console.WriteLine("До вызова метода alpha (): A=" + A);
            // Вызов метода: 
            alpha(A);
            // Проверка значения переменной: 
            Console.WriteLine("После вызова метода alpha: A=" + A);
            // Массив для передачи аргументом методу: 
            int[] B = { 1, 3, 5 };
            // Проверка содержимого массива: 
            Console.WriteLine("До вызова метода bravo (): B=" + ArrayToText(B));
            // Вызов метода: 
            bravo(B);
            // Проверка содержимого массива: 
            Console.WriteLine("После вызова метода bravo (): B=" + ArrayToText(B));
            // Массив для передачи аргументом методу: 
            int[] C = { 2, 4, 6 };
            // Проверка содержимого массива: 
            Console.WriteLine("До вызова метода charlie (): C=" + ArrayToText(C));
            // Вызов метода: 
            charlie(C);
            // Проверка содержимого массива: 
            Console.WriteLine("После вызова метода charlie (): C=" + ArrayToText(C));
        }
    }





    class RefArgsDemo
    {
        static void alpha(ref int n)
        {
            Console.WriteLine("В методе alpha(). На входе: " + n);
            n++;
            Console.WriteLine("В методе alpha(). На выходе: " + n);
        }

        static void bravo(ref int[] n)
        {
            Console.WriteLine("В методе bravo(). На входе: " + ArrayToText(n));
            for (int k = 0; k < n.Length; k++)
            {
                n[k]++;
            }
            Console.WriteLine("В методе bravo(). На выходе:  " + ArrayToText(n));
        }
        static void charlie(ref int[] n)
        {
            Console.WriteLine("В методе charlie(). На входе:  " + ArrayToText(n));
            int[] m = new int[n.Length];
            for (int k = 0; k < n.Length; k++)
            {
                m[k] = n[k] + 1;
            }
            n = m;
            Console.WriteLine("В методе charlie(). На выходе:  " + ArrayToText(n));
        }
        static string ArrayToText(int[] n)
        {
            string res = "[" + n[0];
            for (int k = 1; k < n.Length; k++)
            {
                res += ", " + n[k];
            }
            res += "] ";
            return res;
        }

        static void Main()
        {
            int A = 100;
            Console.WriteLine("До вызова метода alpha(): A=" + A);
            alpha(ref A);
            Console.WriteLine("После вызова метода alpha: A=" + A);

            int[] B = { 1, 3, 5 };
            Console.WriteLine("До вызова метода bravo(): B=" + ArrayToText(B));
            bravo(ref B);
            Console.WriteLine("После вызова метода bravo(): B=" + ArrayToText(B));

            int[] C = { 2, 4, 6 };
            Console.WriteLine("До вызова метода charlie(): C=" + ArrayToText(C));
            charlie(ref C);
            Console.WriteLine("После вызова метода charlie(): C=" + ArrayToText(C));
        }
    }





    class UsingOutDemo
    {
        // Метод для вычисления значения наименьшего элемента
        // в массиве и его индекса:
        static int getMin(int[] nums, out int index)
        {
            // Начальное значение для индекса:
            index = 0;
            // Перебор элементов массива:
            for (int k = 1; k < nums.Length; k++)
            {
                // Если значение элемента массива меньше текущего
                // минимального значения:
                if (nums[k] < nums[index])
                {
                    // Новое значение для индекса:
                    index = k;
                }
            }
            // Результат метода:
            return nums[index];
        }

        // Главный метод программы:
        static void Main()
        {
            // Целочисленный массив:
            int[] A = { 12, 7, 8, 3, 8, 4, 1, 3, 4, 1, 7, 15 };
            // Отображение содержимого массива:
            foreach (int v in A)
            {
                Console.Write("I {0}", v);
                Console.WriteLine("I");
            }

            // Объявление переменных:
            int val, k;
            // Вычисление элемента с наименьшим значением:
            val = getMin(A, out k);
            // Отображение результатов:
            Console.WriteLine("Haимeньшee значение: " + val);
            Console.WriteLine("Индекс элемента: " + k);
            Console.WriteLine("Проверка: A[{0}]={1}", k, A[k]);
        }
    }





    class RecursionDemo
    {
        // Метод для вычисления факториала числа:
        static int factorial(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * factorial(n - 1);
        }
        // Метод для вычисления чисел Фибоначчи:
        static int fibs(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            else
                return fibs(n - 1) + fibs(n - 2);
        }
        // Метод для вычисления суммы чисел:
        static int sum(int n)
        {
            if (n == 0)
                return 0;
            else
                return n + sum(n - 1);
        }
        // Метод для отображения содержимого массива:
        static void show(int[] a, int k)
        {
            // Отображение значения элемента массива:
            Console.Write(a[k] + "  ");
            // Если элемент в массиве последний:
            if (k == a.Length - 1)
            {
                Console.WriteLine();
            }
            // Если элемент в массиве не последний:
            else
            {
                // Рекурсивный вызов метода:
                show(a, k + 1);
            }
        }
        // Перегрузка метода для отображения содержимого массива:
        static void show(int[] a)
        {
            // Вызов версии метода с двумя аргументами:
            show(a, 0);
        }
        // Главный метод программы:
        static void Main()
        {
            Console.WriteLine("Фaктopиaл числа:");
            for (int k = 1; k <= 10; k++)
            {
                // Вычисление факториала числа:
                Console.WriteLine(k + "!=" + factorial(k));
            }

            Console.WriteLine("Чиcлa Фибоначчи:");
            for (int k = 1; k <= 10; k++)
            {
                // Вычисление чисел Фибоначчи:
                Console.Write(fibs(k) + "  ");
            }
            Console.WriteLine();
            Console.Write("Cyммa чисел от 1 до 100:  ");
            Console.WriteLine(sum(100));
            // Числовой массив:
            int[] A = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
            Console.WriteLine("Чиcлoвoй массив:");
            // Отображение всех элементов массива:
            show(A);
            Console.WriteLine("Элeмeнты, начиная с третьего:");
            // Отображение элементов, начиная с третьего:
            show(A, 2);
        }
    }





    class ParamsDemo
    {
        // Метод для вычисления суммы чисел:
        static int sum(params int[] a)
        {
            // Локальная переменная (значение суммы):
            int res = 0;
            // Перебор аргументов метода:
            for (int k = 0; k < a.Length; k++)
            {
                // Прибавление слагаемого к сумме:
                res += a[k];
            }
            // Результат метода:
            return res;
        }
        // Метод для извлечения символов из текста:
        static string getText(string t, params int[] a)
        {
            // Начальное значение формируемой текстовой строки:
            string res = "";
            // Перебор аргументов метода:
            for (int k = 0; k < a.Length; k++)
            {
                // Добавление символа в текст:
                res += t[a[k]];
            }
            // Результат метода:
            return res;
        }
        // Метод отображает значения аргументов:
        static void show(int[] a, params char[] b)
        {
            // Количество элементов в числовом массиве:
            Console.Write("Чиceл " + a.Length + ":  ");
            // Значения элементов в числовом массиве:
            for (int k = 0; k < a.Length - 1; k++)
            {
                Console.Write(a[k] + "  ");
            }
            Console.WriteLine("и " + a[a.Length - 1]);

            // Количество символьных аргументов:
            Console.Write("Cимвoлoв " + b.Length + ":  ");
            // Значения символьных аргументов:
            for (int k = 0; k < b.Length - 1; k++)
            {
                Console.Write(b[k] + "  ");
            }
            Console.WriteLine("и " + b[b.Length - 1]);
        }
        // Главный метод программы:
        static void Main()
        {
            // Примеры вызова методов.
            // Вычисление суммы чисел:
            Console.WriteLine("Cyммa чисел: " + sum(1, 6, 9, 2, 4));
            Console.WriteLine("Cyммa чисел: " + sum(5, 1, 2));

            // Формируется текст:
            Console.WriteLine(getText("Paз два три", 0, 10, 8, 1));
            Console.WriteLine(getText("Бpeвнo", 3, 5, 1, 5, 4));
            // Отображаются аргументы:
            show(new int[] { 1, 3, 5 }, 'А', 'В', 'С', 'D', 'Е');
            show(new int[] { 1, 3, 5, 7, 9 }, 'А', 'В', 'С', 'D');
        }
    }

}


