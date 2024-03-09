using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, h, a;

            Console.Write("Base: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            h = double.Parse(Console.ReadLine());

            a = (b * h) / 2;

            Console.WriteLine("A área é {0}", a);
            Console.ReadKey();
        }
    }
}
