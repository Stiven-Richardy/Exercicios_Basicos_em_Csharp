using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int b, h, a;

            Console.Write("Base: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            h = int.Parse(Console.ReadLine());

            a = b * h;

            Console.WriteLine(" Sua Área será de {0} m²", a);
            Console.ReadKey();
        }
    }
}
