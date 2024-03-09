using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1, v2, v3, v4, v5, t, p, to;

            Console.Write("Valor 1: R$ ");
            v1 = double.Parse(Console.ReadLine());
            Console.Write("Valor 2: R$ ");
            v2 = double.Parse(Console.ReadLine());
            Console.Write("Valor 3: R$ ");
            v3 = double.Parse(Console.ReadLine());
            Console.Write("Valor 4: R$ ");
            v4 = double.Parse(Console.ReadLine());
            Console.Write("Valor 5: R$ ");
            v5 = double.Parse(Console.ReadLine());
            Console.Write("Valor do Pagamento: R$ ");
            p = double.Parse(Console.ReadLine());

            to = v1 + v2 + v3 + v4 + v5;
            t = p - to;

            Console.WriteLine("O seu troco será de {0:c}", t);
            Console.ReadKey();











        }
    }
}
