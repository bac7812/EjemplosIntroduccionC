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
            int[] valores = { 5, 2, 0, 0, 0, 0, 0 };

            System.Console.Write("Introduce un número: ");
            int numero = System.Convert.ToInt32(System.Console.ReadLine());

            for (int m = 0; m < monedas.Length; m++)
            {
                for (int v = 0; v < valores[m]; v++)
                {
                    if (numero >= monedas[m])
                    {
                        numero = numero - monedas[m];
                        System.Console.Write(monedas[m] + " ");
                    }
                }
            }
            System.Console.ReadLine();
        }
    }
}
