using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero;
			int segundoNumero;
			int suma;
            System.Console.WriteLine("Introduce el primer número");
            primerNumero = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Introduce el segundo número");
            segundoNumero = System.Convert.ToInt32(System.Console.ReadLine());
			suma = primerNumero + segundoNumero;
            System.Console.WriteLine("La suma de {0} y {1} es {2}", primerNumero, segundoNumero, suma);
            System.Console.ReadLine();
        }
    }
}
