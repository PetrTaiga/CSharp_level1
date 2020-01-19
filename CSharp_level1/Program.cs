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
            var d = int.Parse(Console.ReadLine());

            NumCount(d);

            Console.WriteLine("Задача №3: подсчитать сумму всех нечетных положительных чисел. Для окончания ввода напечатать ноль: 0.");
            var f = 0;

            SumAllPosOdd(f);

            Console.WriteLine("Задача №4: реализовать метод проверки логина и пароля.На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.");
            var log = "root";
            var pass = "GeekBrains";
            int countauth = 3;

            countauth = AuthMet(log, pass, countauth);

            Console.WriteLine("Задача №5: написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме. Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.");
            Console.Write("Введите вес в килограммах:");
            int weight = Int32.Parse(Console.ReadLine());
            Console.Write("Введите рост в метрах:");
            double height = double.Parse(Console.ReadLine());
            double index = weight / (height * height);
            if (index <= 16)
            {
                Console.WriteLine("Выраженный дефицит массы тела");
            }
            else if (16 < index && index <= 18.5)
            {
                Console.WriteLine("Недостаточная (дефицит) масса тела");
            }
            else if (18.5 < index && index <= 24.99)
            {
                Console.WriteLine("Норма");
            }
            else if (25 < index && index <= 30)
            {
                Console.WriteLine("Избыточная масса тела (предожирение)");
            }
            else if (30 < index && index <= 35)
            {
                Console.WriteLine("Ожирение");
            }
            else if (35 < index && index <= 40)
            {
                Console.WriteLine("Ожирение резкое");
            }
            else if (index > 40)
            {
                Console.WriteLine("Очень резкое ожирение");
            }
            double ideal = 24 * (height * height);
            double diff = weight - ideal;
            if (diff > 0)
            {
                Console.WriteLine("Необходимо похудеть на: " + diff);
            }
            if (diff < 0)
            {
                Console.WriteLine("Необходимо набрать: " + (-diff));
            }
            else if ((int)diff == 0)
            {
                Console.WriteLine("Вы прекрасны!");
            }
        }
        private static int AuthMet(string log, string pass, int countauth)
        {
            while (countauth != 0)
            {
                Console.Write("Login:");
                var testlog = Console.ReadLine();
                Console.Write("Password:");
                var testpass = Console.ReadLine();
                if (testlog != log || testpass != pass)
                {
                    countauth--;
                    Console.WriteLine("Авторизация не пройдена!");
                }
                else if (testlog == log || testpass == pass)
                {
                    Console.WriteLine("Авторизация пройдена!");
                    break;
                }
            }

            if (countauth == 0)
                Console.WriteLine("Закончились попытки!");
            return countauth;
        }

        private static int SumAllPosOdd(int f)
        {
            while (true)
            {
                Console.Write("Введите целое число:");
                var e = Int32.Parse(Console.ReadLine());
                if (e % 2 != 0 && e > 0)
                {
                    f = f + e;
                }
                else if (e == 0)
                {
                    Console.WriteLine("Окончили перечесление!");
                    break;
                }
            }
            Console.WriteLine("Сумма всех нечетных положительных чисел равна: " + f);
            return f;
        }

        private static int NumCount(int d)
        {
            int i = 0;
            while (d > 0)
            {
                i++;
                d /= 10;
            }
            Console.WriteLine("Количество чисел равно: " + i);
            return d;
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
