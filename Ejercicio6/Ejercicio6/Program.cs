using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Introduzca tu edad");
                int edad = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Introduzca tu año de nacimiento");
                int ano = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Mi edad es " + edad + " y mi año de nacimiento es " + ano);
            } catch (FormatException)
            {
                System.Console.WriteLine("No es un número válido");
            }
            System.Console.ReadLine();
        }
    }
}
