using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, l;

            Console.Write("Digite o valor da diagonal:");
            l = double.Parse(Console.ReadLine());

            a = l * l;
            Console.Write("A area e:{0}", a);
            Console.ReadKey();
 
        }
    }
}
