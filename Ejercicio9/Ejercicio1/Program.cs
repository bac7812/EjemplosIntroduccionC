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
            int[] dado = new int[6];
            Random r = new Random(DateTime.Now.Millisecond);

            for (int v = 0; v <=1000; v++)
            {
                int n = r.Next(0, 6);
                dado[n]++;
            }
            for(int d = 0; d<dado.Length; d++)
            {
                System.Console.WriteLine("Dado {0}: {1}", (d + 1), dado[d]);
            }
            System.Console.ReadLine();
        }
    }
}
