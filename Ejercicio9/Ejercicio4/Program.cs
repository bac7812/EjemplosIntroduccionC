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
            HashSet<int> nLista = new HashSet<int>();
            Random r = new Random(DateTime.Now.Millisecond);
            int[] loteria = new int[8];
            for(int c = 0; c <= 5; c++)
            {
                System.Console.Write("Combinación {0}: ", c);
                while (nLista.Count < 7)
                {
                    int nCombinacion = r.Next(1, 49);
                    nLista.Add(nCombinacion);
                }

                int bola = r.Next(0, 9);

                int i = 0;
                foreach (int l in nLista)
                {
                    loteria[i] = l;
                    i++;
                }
                
                loteria[i] = bola;

                for(int n = 0; n<loteria.Length; n++)
                {
					if (n == 6) { 
						System.Console.Write("Complementario: "); 
					}
                    else if (n == 7) { 
						Console.Write("Reintegro: "); 
					}
                    System.Console.Write("{0} ", loteria[n]);
                }
                System.Console.WriteLine();
            }
            System.Console.ReadLine();
        }
    }
}
