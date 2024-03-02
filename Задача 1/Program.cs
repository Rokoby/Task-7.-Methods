using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите параметры");
            int a1 = Convert.ToInt16(Console.ReadLine());
            int b1 = Convert.ToInt16(Console.ReadLine());
            int c1 = Convert.ToInt16(Console.ReadLine());
            int a2 = Convert.ToInt16(Console.ReadLine());
            int b2 = Convert.ToInt16(Console.ReadLine());
            int c2 = Convert.ToInt16(Console.ReadLine());
            double s1 = Square(a1, b1, c1);
            double s2 = Square(a2, b2, c2);
            if (s1 > s2)
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else
                if (s1 < s2)
            {
                Console.WriteLine("Площадь второго треугольника больше");
            }
            else
            {
                Console.WriteLine("Площади равын");
            }
            Console.ReadKey();
        }
        static double Square(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
    }
}
