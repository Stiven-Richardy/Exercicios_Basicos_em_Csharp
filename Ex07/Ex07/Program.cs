using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            double me1, me2, mg;

            Console.Write("Média 1: ");
            me1 = double.Parse(Console.ReadLine());
            Console.Write("Média 2: ");
            me2 = double.Parse(Console.ReadLine());

            mg = Math.Sqrt(me1 * me2);

            Console.WriteLine("A média geométrica dos dois números será: {0}", mg);
            Console.ReadKey();
        }
    }
}
