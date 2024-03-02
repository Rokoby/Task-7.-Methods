using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра");
            int a = Convert.ToInt16(Console.ReadLine());
            int s;
            int v;
            Calculation(a, out s, out v);
            Console.WriteLine("s - {0}, v - {1}", s, v);
            Console.ReadKey();
        }
        static void Calculation (int a, out int s, out int v)
        {
            s = a * a;
            v = a * a * a;
        }
    }
}
