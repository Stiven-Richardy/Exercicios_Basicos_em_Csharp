using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;

            Console.Write("Temperatura em Graus Celsius: ");
            c = double.Parse(Console.ReadLine());

            f = c * 1.8 + 32;

            Console.WriteLine("A conversão para Fahreinheit é: {0}", f);
            Console.ReadKey();
        }
    }
}
