using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] monedas = { 100, 50, 20, 10, 5, 2, 1 };

            System.Console.Write("Dime tu precio: ");
            int precio = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Dime tu pagado: ");
            int pagado = System.Convert.ToInt32(System.Console.ReadLine());

            int devolucion = pagado - precio;

            System.Console.Write("Su cambio es de {0}: ", devolucion);

            for (int m = 0; m < monedas.Length; m++)
            {
                if (devolucion >= monedas[m])
                {

                    devolucion = devolucion - monedas[m];
                    System.Console.Write(monedas[m] + " ");
                    m = 0;
                }

            }

            System.Console.ReadLine();
        }
    }
}
