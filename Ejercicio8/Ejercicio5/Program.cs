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
            System.Console.WriteLine("Introduce tu número");
            int numero = System.Convert.ToInt32(System.Console.ReadLine());

            int tamano = (factorial(numero) / (factorial(numero/2) * factorial(numero - numero/2))).ToString().Length;
            int espacios = tamano * numero;

            for (int n = 0; n < numero; n++)
            {
                for (int a = 0; a < espacios; a++)
                { 
                    System.Console.Write(" ");
                }
                for (int k = 0; k <= n; k++)
                {
                    long f = factorial(n) / (factorial(k) * factorial(n - k));
                    System.Console.Write(f);
                    for (int d = 0; d < tamano-f.ToString().Length+1; d++)
                    {
                        System.Console.Write(" ");
                    }
                }
               espacios -= tamano;
               System.Console.WriteLine();
            }
            System.Console.ReadLine();
        }

        public static long factorial(int f)
        {
            int m = 1;
            
            for (int i = 1; i <= f; i++)
            {
                m = m * i;
            }
            return m;
        }
    }
}
