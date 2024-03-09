using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            double mm, km;

            Console.Write("Milhas Marítimas: ");
            mm = double.Parse(Console.ReadLine());

            km = mm * 1852;

            Console.WriteLine("{0} Km", km);
            Console.ReadKey();

           

            
           


        }
    }
}
