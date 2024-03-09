using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, r, u;

            Console.Write("Resistência: ");
            r = double.Parse(Console.ReadLine());

            Console.Write("Corrente Elétrica: ");
            i = double.Parse(Console.ReadLine());

            u = i * r;

            Console.WriteLine("A tensão elétrica é: {0} ", u);
            Console.ReadKey();


        }
    }
}
