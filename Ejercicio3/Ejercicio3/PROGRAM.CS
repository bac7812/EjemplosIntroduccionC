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
            int primerNumero;
            int segundoNumero;
            System.Console.WriteLine("Introduce el primer número");
            primerNumero = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Introduce el segundo número");
            segundoNumero = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Divisores comunes: ");
            for (int i = 1; i < primerNumero; i++)
            {
                if (primerNumero % i == 0 && segundoNumero % i == 0)
                {
                    System.Console.WriteLine(i + " ");
                }
            }
            System.Console.ReadLine();
        }
    }
}
