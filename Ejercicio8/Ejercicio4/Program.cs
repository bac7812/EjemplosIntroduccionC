using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int perfectoA = 0;
            int perfectoB = 0;
            System.Console.WriteLine("Introduce un número A");
            int numeroA = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Introduce un número B");
            int numeroB = Convert.ToInt32(System.Console.ReadLine());
            for (int num = 1; num < numeroA; num++)
            {
                if (numeroA % num == 0)
                {
                    perfectoA = perfectoA + num;
                }
            }
            for (int num = 1; num < numeroB; num++)
            {
                if (numeroB % num == 0)
                {
                    perfectoB = perfectoB + num;
                }
            }
            if (perfectoA == numeroB & perfectoB == numeroA)
            {
                System.Console.WriteLine("{0} y {1} son numeros amigos", perfectoA, perfectoB);
            }
            else
            {
                System.Console.WriteLine("{0} y {1} no son numeros amigos", perfectoA, perfectoB);
            }
            System.Console.ReadLine();
        }
    }
}
