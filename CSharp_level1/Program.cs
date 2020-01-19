using System;

namespace CSharp_level1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №1: найти минимальное число из трёх.");
            Console.Write("Введите первое число:");
            var a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите второе число:");
            var b = Int32.Parse(Console.ReadLine());
            Console.Write("Введите третье число:");
            var c = Int32.Parse(Console.ReadLine());

            MinNum(a, b, c);

            Console.WriteLine("Задача №2: посчитать количество цифр в целом положительном числе.");
            Console.Write("Введите число для подсчёта цифр:");
            var d = Int32.Parse(Console.ReadLine());

            int i = 0;
            while (d > 0)
            {
                i++;
                d /= 10;
            }
            Console.WriteLine("Количество чисел равно: " + i);

        }

        private static void MinNum(int a, int b, int c)
        {
            int j;
            int g;
            if (a < b)
            {
                j = a;
            }
            else
            {
                j = b;
            }

            if (j < c)
            {
                g = j;
            }
            else
            {
                g = c;
            }
            Console.WriteLine("Наименьшее число: " + g);
        }
    }
}
