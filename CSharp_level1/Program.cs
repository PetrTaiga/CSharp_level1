using System;

namespace CSharp_level1
{
    struct Complex
    {
        public double im;
        public double re;
     
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public Complex Subtrac(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public override string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №1: дописать класс комплексных чисел, добавить вычитание.");
            Complex complex1;
            Console.WriteLine("Создадим первое комплексное число.");
            Console.WriteLine("Введите рациональную часть комплексного числа:");
            complex1.re = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите иррациональную часть комплексного числа:");
            complex1.im = double.Parse(Console.ReadLine());

            Complex complex2;
            Console.WriteLine("Создадим второе комплексное число.");
            Console.WriteLine("Введите рациональную часть комплексного числа:");
            complex2.re = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите иррациональную часть комплексного числа:");
            complex2.im = double.Parse(Console.ReadLine());

            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString() + " результат сложения комплексных чисел");

            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString() + " результат умножения комплексных чисел");

            result = complex1.Subtrac(complex2);
            Console.WriteLine(result.ToString() + " результат вычитания комплексных чисел");

            Console.WriteLine("Задача №2: требуется подсчитать сумму всех нечетных положительных чисел, добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. Для остановки программы введите: 0.");
            double f = 0;

            while (true)
            {
                Console.Write("Введите целое число:");
                var e = Console.ReadLine();
                bool success = double.TryParse(e, out double check);
                if (success)
                {
                    double numVal = Convert.ToDouble(e);
                    if (numVal % 2 != 0 && numVal > 0)
                    {
                        f = f + numVal;
                    }
                    else if (numVal == 0)
                    {
                        Console.WriteLine("Окончили перечесление!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода. Введите цифру.");
                }
            }
            Console.WriteLine("Сумма всех нечетных положительных чисел равна: " + f);
        }
    }

}
