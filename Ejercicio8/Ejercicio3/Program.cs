using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int perfecto = 0;
            System.Console.WriteLine("Introduce un número");
            int numero = Convert.ToInt32(System.Console.ReadLine());
            for(int num=1; num < numero; num++)
            {
                if(numero % num == 0)
                {
                    perfecto = perfecto + num;
                }
            }
            if(numero == perfecto)
            {
                System.Console.WriteLine("{0} es un número perfecto", perfecto);
            }
            else
            {
                System.Console.WriteLine("{0} no es un número perfecto", perfecto);
            }
            System.Console.ReadLine();
        }
    }
}