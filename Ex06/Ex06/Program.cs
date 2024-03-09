using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            double ma, me1, me2, me3, me4;

            Console.Write("Média 1: ");
            me1 = double.Parse(Console.ReadLine());
            Console.Write("Média 2: ");
            me2 = double.Parse(Console.ReadLine());
            Console.Write("Média 3: ");
            me3 = double.Parse(Console.ReadLine());
            Console.Write("Média 4: ");
            me4 = double.Parse(Console.ReadLine());

            ma = (me1 + me2 + me3 + me4) / 5;

            Console.WriteLine("A Média Aritmética desses 4 números é: {0}", ma);
            Console.ReadKey();


        }
    }
}
