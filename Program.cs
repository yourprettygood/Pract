using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 4 

            //	Пушка стреляет под углом 30° к линии горизонта. Масса снаряда 30 кг, начальная скорость 500 м/с. Найти дальность полета снаряда?
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
            
            Console.Write("Введите действительное число a: ");
            double a = Convert.ToDouble(Console.ReadLine());
          
            double a2 = a * a;       
            double a4 = a2 * a2;       
            double a8 = a4 * a4;           
            double a16 = a8 * a8;           
            double a20 = a16 * a4;          
            double a21 = a20 * a;

            Console.WriteLine($"a^21 = {a21}");
            



            Console.ReadLine();
        }
    }
}
