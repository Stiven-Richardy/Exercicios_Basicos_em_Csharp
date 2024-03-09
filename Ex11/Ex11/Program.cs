using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            double d, r, a;

            Console.Write("Diâmetro: ");
            d = double.Parse(Console.ReadLine());

            r = d / 2;
            a = Math.PI * Math.Pow(r, 2);

            Console.WriteLine("A área é: {0}", a);
            Console.ReadKey();
        }
    }
}
