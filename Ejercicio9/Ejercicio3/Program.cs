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
            int suma = 0;
            HashSet<int> nLista = new HashSet<int>();
            Console.Write("Introduce un número entero: ");
            int n = System.Convert.ToInt32(System.Console.ReadLine());
            Random r = new Random(DateTime.Now.Millisecond);

            while(nLista.Count <= n)
            {
                int nAleatorios = r.Next(0, 100);
                nLista.Add(nAleatorios);
            }

            foreach(int s in nLista)
            {
                suma += s;
            }

            int total = suma / n;
            Console.WriteLine("El total es: {0}", total);
            System.Console.ReadLine();
        }
    }
}
