using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, a;

            Console.Write("Aresta: ");
            r = int.Parse(Console.ReadLine());

            a = r * r;

            Console.WriteLine("A área é {0}", a);
            Console.ReadKey();

        }
    }
}
