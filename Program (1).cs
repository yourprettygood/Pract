using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
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
            //2
            /*
            Console.Write("Введите 2-х значнон число: ");
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
            //3
            Console.Write("Введите x: ");
            double x = int.Parse(Console.ReadLine());
            Console.Write("Введите y: ");
            double y =int.Parse(Console.ReadLine());

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


            Console.ReadLine();
        }
    }
}
