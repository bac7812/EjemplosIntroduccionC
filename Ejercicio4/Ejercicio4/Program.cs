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
            int numeroLetra = 0;
            Console.Write("Dime tu nombre: ");
            string nombre = Console.ReadLine();
            foreach (char letra in nombre)
            {
                if (Convert.ToString(letra) == "a")
                {
                    numeroLetra++;
                }
                if (Convert.ToString(letra) == "A")
                {
                    numeroLetra++;
                }
            }
            Console.WriteLine(numeroLetra);
            Console.ReadLine();
        }
    }
}
