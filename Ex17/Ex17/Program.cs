using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17
{
    class Program
    {
        static void Main(string[] args)
        {
     
             double x, y, r;

                Console.Write("Valor de X : ");
                x = double.Parse(Console.ReadLine());

                Console.Write("Valor de Y : ");
                y = double.Parse(Console.ReadLine());

                r = Math.Exp(y * Math.Log(x));
                // r = Math.Pow(x, y);

                Console.Write("{0} elevado a {1} = {2}", x, y, r);
                Console.ReadKey();
            }
        }
    }


    

