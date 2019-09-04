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
            string [] dni = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            System.Console.Write("Introduce número de DNI: ");
            int nDNI = System.Convert.ToInt32(System.Console.ReadLine());
            int nLetra = nDNI % 23;
            string Letra = dni[nLetra];
            System.Console.WriteLine("El DNI es {0}-{1}", nDNI, Letra);
            System.Console.ReadLine();
        }
    }
}
