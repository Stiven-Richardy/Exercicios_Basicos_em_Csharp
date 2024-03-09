using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            double vf1, vf2, vi, a, t;

            Console.Write("Velocidade Inicial: ");
            vi = double.Parse(Console.ReadLine());
            Console.Write("Aceleração: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Tempo de Percurso: ");
            t = double.Parse(Console.ReadLine());

            vf1 = vi + a * t;
            vf2 = vf1 * 3.6;

            Console.WriteLine("A velocidade Final será: {0} km/h", vf2);
            Console.ReadKey();


           

      
        }
    }
}
