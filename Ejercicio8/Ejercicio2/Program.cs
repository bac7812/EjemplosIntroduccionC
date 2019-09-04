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
            int positivos = 0;
            int contar = 0;
            int numero;

            System.Console.WriteLine("Introduce número");
            numero = Convert.ToInt32(System.Console.ReadLine());

            while (numero != 999)
            {
                contar = contar + 1;
                if (numero > 0) positivos = positivos + 1;

                Console.WriteLine("Introduce número");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine("Has introducido un total de {0}", contar);
            System.Console.WriteLine("y son positivos {0}", positivos);
            System.Console.ReadLine();

        }
    }
}
