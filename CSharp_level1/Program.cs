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
            Console.Write("Наименьшее число: " + g);
        }
    }
}
