using System;

namespace secondApl
{
    class Program
    {
        static void Main(string[] args)
        {
            /* задача 1
            Random random = new Random(0);
            int a = random.Next(4);
            int b = random.Next(4);

            Console.WriteLine($"Число {a} {(a % 2 == 0 ? "чётное" : "нечётное")}\n" +
                              $"Число второе {b} {(b % 2 == 0 ? "чётное" : "нечётное")}");
            */
            /* задание 2
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number2 >= number3 && number1 >= number2)
            {
                Console.WriteLine($"Число {number1} самое большое");
            }
            else if (number2 >= number1 && number2 >= number3)
            {
                Console.WriteLine($"Число {number2} самое большое");
            }
            else if (number3 >= number1 && number3 >= number2)
            {
                Console.WriteLine($"Число {number3} самое большое");
            }
            */
            /* задача 3
            Console.WriteLine("Введите радиус круга:");
            string str1 = Console.ReadLine();
            int R = int.Parse(str1);

            Console.WriteLine("Введите X координату точки:");
            string str2 = Console.ReadLine();
            int x = int.Parse(str2);

            Console.WriteLine("Введите Y координату точки:");
            string str3 = Console.ReadLine();
            int y = int.Parse(str3);

            if ((x * x) + (y * y) == R * R)
            {
                Console.WriteLine("Заданная точка лежит на окружности");
            }
            else if ((x * x) + (y * y) < R * R)
            {
                Console.WriteLine("Заданная точка находится внутри круга");
            }
            else if ((x * x) + (y * y) > R * R)
            {
                Console.WriteLine("Заданная точка находится за пределами круга");
            }
            */
            /* задача 4
            Random rnd = new Random();
            int a = rnd.Next(0, 31);
            switch (a)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine($"Число {a} попало в первый диапазон (0,10).");
                    break;
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                    Console.WriteLine($"Число {a} попало во второй диапазон [10, 20).");
                    break;
                default:
                    Console.WriteLine($"Число {a} попало в третий диапазон [20,30].");
                    break;
            }
            */
            /* Задача 5
            Console.WriteLine("Введите год: ");
            string str = Console.ReadLine();
            int y = int.Parse(str);
            if (y % 4 != 0)
            {
                Console.WriteLine("Обычный год");
            }
            else if (y % 100 == 0)
            {
                Console.WriteLine("Столетие");
            }
            else if (y % 400 == 0)
            {
                Console.WriteLine("Високосный год");
            }
            else
            {
                Console.WriteLine("Обычный год");
            }
            */
        }
    }
}
