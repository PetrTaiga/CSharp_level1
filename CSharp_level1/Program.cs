using System;

namespace CSharp_level1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ваше имя:");
            var a = Console.ReadLine();

            Console.Write("Ваша фамилия:");
            var b = Console.ReadLine();

            Console.Write("Ваш возраст:");
            var c = Console.ReadLine();

            Console.WriteLine("Имя:" + a + " Фамилия:" + b + " Возраст:" + c);
            Console.WriteLine("Имя:" + a + " Фамилия:" + b + " Возраст:" + string.Format(c));
            Console.WriteLine($"Имя:{a} Фамилия:{b} Возраст:{c}");
            Console.ReadKey();
        }
    }
}
