using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, r, v;

            Console.Write("Altura: ");
            h = double.Parse(Console.ReadLine());
            Console.Write("Raio: ");
            r = double.Parse(Console.ReadLine());

            v = Math.PI * (r * r) * h / 3;

            Console.WriteLine("O volume é: {0}", v);
            Console.ReadKey();







        }
    }
}
