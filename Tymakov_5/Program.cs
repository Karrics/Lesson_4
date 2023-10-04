using System;


namespace Tymakov_5
{
    internal class Program
    {
        static int Max(int x, int y)
        {
            return Math.Max(x, y);
        }

        static void ChangeRef(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }

        static bool fact(ref int nummer)
        {
            int c = nummer;
            nummer = 1;
            for (int i = 1; i <= c; i++)
                try
                {
                    checked
                    {
                        nummer *= i;
                    }
                }
                catch { return false; }
            return true;
        }

        static ulong Factorial(ulong x) 
        {
            try
            {
                if (x == 0)
                {
                    return 1;
                }
                return x * Factorial(x - 1);
            }
            catch (System.StackOverflowException)
            {
                return 0;
            }
        }

        static int NOD(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        static int NOD(int a, int b, int c)
        {
            return NOD(a, NOD(b, c));
        }

        static int Fib(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            else if (a == 2)
            {
                return 1;
            }
            else
            {
                return Fib(a-1) + Fib(a-2);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Упр 5.1");
            Console.WriteLine("Вернуть максимальное число");
            try
            {
                Console.WriteLine("Числа должны быть целыми");
                Console.Write("Введите первое число: ");
                int num_1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int num_2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Max(num_1, num_2));
            }
            catch (FormatException)
            {
                Console.WriteLine("Неккоректно введено число");
            }
            Console.WriteLine();


            Console.WriteLine("Упр 5.2");
            Console.WriteLine("Поменять входные параметры местами");
            try
            {
                Console.WriteLine("Числа должны быть целыми");
                Console.Write("Введите первое число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                ChangeRef(ref a, ref b);
                Console.WriteLine($"x = {a}, y = {b}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неккоректно введено число");
            }
            Console.WriteLine();


            Console.WriteLine("Упр 5.3");
            Console.WriteLine("Найти факториал числа");
            try
            {
                Console.WriteLine("Число должно быть целым");
                Console.Write("Введите число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                bool flag = fact(ref a);
                Console.WriteLine(Convert.ToString(flag) + " " + a);
            }
            catch (FormatException)
            {
                Console.WriteLine("Неккоректно введено число");
            }
            Console.WriteLine();


            Console.WriteLine("Упр 5.4");
            Console.WriteLine("Найти факториал числа рекурсией");
            try 
            {
                Console.WriteLine("Число должно быть целым и не больше 65");
                Console.WriteLine("Иначе будет возвращён 0");
                Console.Write("Введите число: ");
                ulong x = Convert.ToUInt64(Console.ReadLine());
                Console.WriteLine("Факториал равен = " + Factorial(x));
            }
            catch (FormatException)
            {
                Console.WriteLine("Неккоректно введено число");
            }
            Console.WriteLine();


            Console.WriteLine("Дз 5.1");
            Console.WriteLine("Алгоритм Евклида");
            try
            {
                Console.WriteLine("Введите целые числа");
                Console.Write("A = ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("B = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Наибольший общий делитель чисел {0} и {1} равен {2}", a, b, NOD(a, b));
            }
            catch (FormatException)
            {
                Console.WriteLine("Неккоректно введено число");
            }
            Console.WriteLine();
            try
            {
                Console.WriteLine("НОД для трёх чисел");
                Console.WriteLine("Введите целые числа");
                Console.Write("A = ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("B = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("C = ");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Наибольший общий делитель чисел {0}, {1} и {2} равен {3}", a, b, c, NOD(a, b, c));
            }
            catch (FormatException)
            {
                Console.WriteLine("Неккоректно введено число");
            }
            Console.WriteLine();


            Console.WriteLine("Дз 5.2");
            Console.WriteLine("Последовательность Фибоначи");
            try
            {
                Console.WriteLine("Укажите номер числа в последовательности");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Число в последовательности Фибоначи под номером {0} равно {1}", a, Fib(a));
            }
            catch (FormatException)
            {
                Console.WriteLine("Неккоректно введено число");
            }
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу для завершения");
            Console.ReadKey();
        }
    }
}
