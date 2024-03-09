using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, d, r;

            Console.Write("Cotação Atual do Dólar: ");
            c = double.Parse(Console.ReadLine());
            Console.Write("Dólar: ");
            d = double.Parse(Console.ReadLine());

            r = c * d;

            Console.WriteLine("Você tem {0:c} ", r);
            Console.ReadKey();



        }
    }
}
