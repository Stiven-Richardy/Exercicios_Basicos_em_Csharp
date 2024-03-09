using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, se, co, ta, sc, r;

            Console.Write("Ângulo em graus: ");
            a = double.Parse(Console.ReadLine());

            r = a * Math.PI / 180;

            se = Math.Sin(r);
            co = Math.Cos(r);
            ta = Math.Tan(r);
            sc = 1 / Math.Cos(r);

            Console.WriteLine("Seno é: {0:f5} em Radianos", se);
            Console.WriteLine("Cosseno é: {0} em Radianos", co);
            Console.WriteLine("Tangente é: {0} em Radianos", ta);
            Console.WriteLine("Secante é: {0} em Radianos", sc);
            Console.ReadKey();


        }
    }
}
