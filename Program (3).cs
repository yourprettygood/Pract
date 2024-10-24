using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //pract 1
            //Задание 4 

            //Напишите программу, запрашивающую высоту дома h(в метрах), ускорение свободного паденияgи вычисляющую время падения кирпичаt(в секундах) с крыши этого дома по формуле: .
            /* 
            Console.Write("Введите высоту дома (в метрах): ");
            double h = Convert.ToDouble(Console.ReadLine());

            double x = 9.0;

            double t = Math.Sqrt(2 * h / x);

            Console.WriteLine($"Время падения кирпича: {t:F2} секунд");

            */

            // Задание 5 9.	Найдите сумму п членов арифметической прогрессии, первый член которой равен n, а разность равна d

            /*
            Console.Write("Введите первый член (n): ");
            double n = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите разность (d): ");
            double d = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество членов (p): ");
            int p = Convert.ToInt32(Console.ReadLine());

            double sum = (p / 2.0) * (2 * n + (p - 1) * d);

            Console.WriteLine($"Сумма первых {p} членов арифметической прогрессии: {sum}");
            */

            //Задание 6

            /*
            Console.Write("x =");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = 20 * Math.Log10(Math.Cos(Math.Pow(Math.E, 2))) - (2 / (Math.Sqrt(Math.Pow(Math.Sin(Math.PI), 2) + Math.Abs(1 - Math.Pow(x, 3)))));
            Console.WriteLine($"y = {y}");
            */
            //Задание 7

            //9.	а21 за шесть операции, а – действительное число, при этом, не пользуясь никакими другими арифметическими операциями, кроме умножения.
            /*
            Console.Write("Введите действительное число a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            double a2 = a * a;
            double a4 = a2 * a2;
            double a8 = a4 * a4;
            double a16 = a8 * a8;
            double a20 = a16 * a4;
            double a21 = a20 * a;

            Console.WriteLine($"a^21 = {a21}");
            */



            //4 PRACT
            //1 Написать программу, которая вычисляет значение функции у:
            /*
            Console.Write("Введите x: ");
            double x = int.Parse(Console.ReadLine());
            double y;
            if (x <= Math.PI)
            {
                y = x + 2 * Math.Sin(3 * x);
                Console.WriteLine($"y = {y}");
            }
            else
            {
                y = Math.Cos(x + 2);
                Console.WriteLine($"y = {y}");
            }
            */

            //2.	является ли сумма цифр двухзначного числа четной.   
            /*
            Console.Write("Введите 2-х значное число: ");
            int x = int.Parse(Console.ReadLine());
            int summ = (x / 10) + x % 10;

            if (summ %2==0)
            {
               Console.WriteLine($"Сумма числа {x} ({summ}) четная");

            }
            else
            {
                Console.WriteLine($"Сумма числа {x} ({summ}) не четная");
            }
            */
            //3Дана точка на плоскости с координатами (х, у). Составить программу, которая выдает одно из сообщений "Да", "Нет",
            //"На границе" в зависимости от того, лежит ли точка внутри заштрихованной области, вне заштрихованной области или на ее границе. 
            //Области задаются графически следующим образом

            /*
            Console.Write("Введите x: ");
            double x = int.Parse(Console.ReadLine());
            Console.Write("Введите y: ");
            double y = int.Parse(Console.ReadLine());

            if (y == 12 || y == Math.Abs(x))
            {
                Console.WriteLine("На границе");
            }
            else if (y < 12 && y > Math.Abs(x))
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
            */

            

            Console.ReadLine();
        }
    }
}
