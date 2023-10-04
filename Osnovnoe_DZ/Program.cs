using System;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace Osnovnoe_DZ
{
    internal class Program
    {
        enum Grouchiness
        {
            low,
            medium,
            high
        }

        struct DED
        {
            public string Name;
            public Grouchiness grouchiness;
            public string[] Words;
            public int hit;

            public int Phrase(params string[] Grouchiness_words)
            {
                int hit = 0;
                foreach (string word in Words)
                {
                    foreach (string badWord in Grouchiness_words)
                    {
                        if (badWord == word)
                        {
                            hit += 1;
                        }
                    }
                }

                return hit;
            }
        }

        public static void About_Array(ref double sum, ref double increase, out double average, params double[] array)
        {
            average = sum = 0;
            increase = 1;
            foreach (double number in array)
            {
                sum += number;
                increase *= number;
            }
            average = sum / array.Length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Упр 1");
            Console.WriteLine("Поменять два числа в массиве местами");
            Console.WriteLine();
            Random random = new Random();
            int[] array = new int[20];
            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next();
            }
            foreach (int num in  array)  // Распечатываем массив первый раз
            {
                Console.WriteLine(num);
            }
            try
            {
                int j = 0;
                Console.WriteLine("Введите одно число из данного массива");
                if (int.TryParse(Console.ReadLine(), out int num_1))
                {
                    Console.WriteLine("Введите второе число из данного массива");
                    if (int.TryParse(Console.ReadLine(), out int num_2))
                    {
                        foreach (int num1 in array)
                        {
                            if (num1 == num_1) 
                            {
                                j += 1;
                                foreach (int num2 in array)
                                {
                                    if (num2 == num_2)
                                    {
                                        j += 1;
                                        (array[Array.IndexOf(array, num_1)], array[Array.IndexOf(array, num_2)]) = (array[Array.IndexOf(array, num_2)], array[Array.IndexOf(array, num_1)]);
                                    }
                                }
                            }
                        }
                    }
                }
                if (j < 2)
                {
                    Console.WriteLine("Введено не число или число, которого нет в массиве");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Массив после изменений:");
                    Console.WriteLine();
                    foreach (int num in array) // Выводим изменённый массив
                    {
                        Console.WriteLine(num);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неккоректно введено число");
            }
            Console.WriteLine();


            Console.WriteLine("Упр 2");
            Console.WriteLine("Рабоота с массивом");
            Console.WriteLine("Укажите длинну массива");
            try
            {
                if (int.TryParse(Console.ReadLine(), out int len))
                {
                    double[] Array_2 = new double[len];
                    if (len == 0)
                    {
                        Console.WriteLine("Пустой массив");
                    }
                    else
                    {
                        for (int i = 0; i < len; i++)
                        {
                            Console.Write($"Введите элемент массива номер {i + 1}: ");
                            double num = double.Parse(Console.ReadLine());
                            Array_2[i] = num;
                        }
                    }
                    double increase = 1;
                    double average;
                    double sum = 0;
                    About_Array(ref sum, ref increase, out average, Array_2);
                    Console.WriteLine("Сумма элементов: {0}", sum);
                    Console.WriteLine("Произведение элементов: {0}", increase);
                    Console.WriteLine("Среднее значение: {0}", average);
                }
            }
            catch (FormatException) 
            {
                Console.WriteLine("Неккоректно введено число");
            }
            Console.WriteLine();


            Console.WriteLine("Упр 3");
            Console.WriteLine("Время рисовать цифры");
            Console.WriteLine("Введите число от 0 до 9 или 'exit' / 'закрыть' для завершения работы");
            string str = Console.ReadLine();
            if (str == "exit" || str == "закрыть")
            {
                System.Environment.Exit(0);
            }
            try
            {
                if (int.TryParse(str, out int num))
                {
                    if (num < 0 || num > 9)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Вы ввели не допустимое число");
                        Thread.Sleep(3000);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine();
                        if (num == 0)
                        {
                            Console.WriteLine(" ### ");
                            Console.WriteLine(" # # ");
                            Console.WriteLine(" # # ");
                            Console.WriteLine(" ### ");
                        }
                        if (num == 1)
                        {
                            Console.WriteLine("  #  ");
                            Console.WriteLine(" ##  ");
                            Console.WriteLine("  #  ");
                            Console.WriteLine(" ### ");
                        }
                        if (num == 2)
                        {
                            Console.WriteLine("  ### ");
                            Console.WriteLine(" #  # ");
                            Console.WriteLine("   #  ");
                            Console.WriteLine("  ### ");
                        }
                        if (num == 3)
                        {
                            Console.WriteLine(" ### ");
                            Console.WriteLine(" #   ");
                            Console.WriteLine(" ###  ");
                            Console.WriteLine(" #   ");
                            Console.WriteLine(" ### ");
                        }
                        if (num == 4)
                        {
                            Console.WriteLine(" # # ");
                            Console.WriteLine(" ### ");
                            Console.WriteLine("   # ");
                            Console.WriteLine("   # ");
                        }
                        if (num == 5)
                        {
                            Console.WriteLine(" ### ");
                            Console.WriteLine(" #   ");
                            Console.WriteLine(" ### ");
                            Console.WriteLine("   # ");
                            Console.WriteLine(" ### ");
                        }
                        if (num == 6)
                        {
                            Console.WriteLine(" ### ");
                            Console.WriteLine(" #   ");
                            Console.WriteLine(" ### ");
                            Console.WriteLine(" # # ");
                            Console.WriteLine(" ### ");
                        }
                        if (num == 7)
                        {
                            Console.WriteLine(" ### ");
                            Console.WriteLine("   # ");
                            Console.WriteLine("   # ");
                            Console.WriteLine("   # ");
                        }
                        if (num == 8)
                        {
                            Console.WriteLine(" ### ");
                            Console.WriteLine(" # # ");
                            Console.WriteLine(" ### ");
                            Console.WriteLine(" # # ");
                            Console.WriteLine(" ### ");
                        }
                        if (num == 9)
                        {
                            Console.WriteLine(" ### ");
                            Console.WriteLine(" # # ");
                            Console.WriteLine(" ### ");
                            Console.WriteLine("   # ");
                            Console.WriteLine(" ### ");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Введено не число");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неккоректно введено число");
            }
            Console.WriteLine();


            Console.WriteLine("Упр 4");
            Console.WriteLine("Избиение деда за брань (Количество ударов от бабки)");
            string[] Grouchiness_words = {"Проститутки", "Гады" };

            string[] dedWords_1 = { "Гады", "Дурак", "Пендос", "Дебил", "Балбес", };
            string[] dedWords_2 = { "Ужас", "Дурак", "Проститутки" };
            string[] dedWords_3 = { "Дебил", "Гнида"};
            string[] dedWords_4 = { "Гады", "Проститутки", "Псина", "Чудик", "Мудак"};
            string[] dedWords_5 = { "Проститутка", "Сука", "Хохол", "Дурак", "Мудак", "Ебл*н" };

            DED ded_1 = new DED();
            ded_1.Name = "Никита";
            ded_1.grouchiness = Grouchiness.high;
            ded_1.Words = dedWords_1;
            ded_1.hit = ded_1.Phrase(Grouchiness_words);

            DED ded_2 = new DED();
            ded_2.Name = "Влад";
            ded_2.grouchiness = Grouchiness.medium;
            ded_2.Words = dedWords_2;
            ded_2.hit = ded_2.Phrase(Grouchiness_words);

            DED ded_3 = new DED();
            ded_3.Name = "Игорь";
            ded_3.grouchiness = Grouchiness.low;
            ded_3.Words = dedWords_3;
            ded_3.hit = ded_3.Phrase(Grouchiness_words);

            DED ded_4 = new DED();
            ded_4.Name = "Женя";
            ded_4.grouchiness = Grouchiness.high;
            ded_4.Words = dedWords_4;
            ded_4.hit = ded_4.Phrase(Grouchiness_words);

            DED ded_5 = new DED();
            ded_5.Name = "Михаил";
            ded_5.grouchiness = Grouchiness.high;
            ded_5.Words = dedWords_5;
            ded_5.hit = ded_5.Phrase(Grouchiness_words);
            Console.WriteLine("Количество фингалов у {0}: {1}", ded_1.Name, ded_1.hit);
            Console.WriteLine("Количество фингалов у {0}: {1}", ded_2.Name, ded_2.hit);
            Console.WriteLine("Количество фингалов у {0}: {1}", ded_3.Name, ded_3.hit);
            Console.WriteLine("Количество фингалов у {0}: {1}", ded_4.Name, ded_4.hit);
            Console.WriteLine("Количество фингалов у {0}: {1}", ded_5.Name, ded_5.hit);


            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для завершения");


            Console.ReadKey();
        }
    }
}
