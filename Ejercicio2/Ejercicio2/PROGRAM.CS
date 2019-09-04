using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Introduce el número");
            int numero = System.Convert.ToInt32(System.Console.ReadLine());
            for (int multiplicar = 1; multiplicar <= numero; multiplicar++)
            {
                Console.WriteLine("{0} por {1} es {2}", multiplicar, 9, multiplicar * 9);
            }
            System.Console.ReadLine();
        }
    }
}
