using System;

namespace MegaBrain
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Первое задание
            int value1 = 3;
            int value2 = 4;
            int value3 = 0;

            value3 = value1;
            value1 = value2;
            value2 = value3;
            value3 = 0;

            Console.WriteLine($"value1 = {value1}, value2 = {value2}, value3 = {value3}");
            */

            /* Вторая задача
            Console.WriteLine("Введите числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            a = a * 3;
            b = b + 12;

            string victorSergeevich = ($"a = {a}, b = {b}");

            Console.WriteLine(victorSergeevich);
            */

            /*  Задача 3
            int milkPrice = 54;
            int matchesPrice = 2;
            string questionMilk = "Сколько пачек молока вы купили?";
            string questionMatches = "Сколько пачек спичек вы купили?";

            Console.WriteLine(questionMilk);
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(questionMatches);
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"На молоко вы потратили {a * milkPrice}, а на спички {b * matchesPrice} и общая сумма {(a * milkPrice) + (b * matchesPrice)}");
            */

            /* четвертая задача
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a % b == 0)
            {
                Console.WriteLine($"Сумма чисел равна {a + b}, разность равна {a / b}, а произведение {a * b}");
            }
            else {
                Console.WriteLine("Число не делится без остатка");
            };
            */
            /*
             Пятая задача
            while (true)
            {
                int q = Convert.ToInt16(Console.ReadLine());
                int w = Convert.ToInt16(Console.ReadLine());
                if (q % w == 0)
                {
                    Console.WriteLine($"Деление без остатка. Ответ: {q / w}");
                }
                else
                {
                    Console.WriteLine($"Деление с остатком. Ответ: {q / w}, остаток: {q % w}");
                }
            }
            */

        }
    }
}
