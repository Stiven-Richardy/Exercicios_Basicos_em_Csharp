using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, a, ve, vc, vl;

            Console.Write("Raio: ");
            r = double.Parse(Console.ReadLine());
            Console.Write("Aresta: ");
            a = double.Parse(Console.ReadLine());

            ve = 4 * Math.PI * (r * r * r) / 3;
            vc = (a * a * a);
            vl = ve - vc;

            Console.WriteLine("O volume livre é: {0} ", vl);
            Console.ReadKey();
        }
    }
}
