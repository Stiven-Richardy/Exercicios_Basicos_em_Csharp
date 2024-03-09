using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            double d, r, v, pi;

            Console.Write("Diâmetro: ");
            d = double.Parse(Console.ReadLine());

            r = d / 2;
            r = r * r * r;
            pi = Math.PI;
            v = 4 * r * pi / 3;

            Console.WriteLine("O volume é {0}", v);
            Console.ReadKey();
        }
    }
}
