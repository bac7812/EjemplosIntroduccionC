using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Jornada
    {
        public static List<string> partido = new List<string>();

        public static LinkedList<string> equipoLocal = new LinkedList<string>();

        public static LinkedList<string> equipoVisitante = new LinkedList<string>();

        public static void InsertarAlPrincipio()
        {
            equipoLocal.AddFirst(equipoLocal.Last());
            equipoLocal.RemoveFirst();
            //Partido();
        }

        public static void InsertarAlFinal()
        {
            equipoVisitante.AddLast(equipoLocal.Last());
            equipoLocal.RemoveLast();
            equipoLocal.AddLast(equipoLocal.First());
            equipoLocal.RemoveFirst();
            equipoLocal.AddFirst(equipoVisitante.First());
            equipoVisitante.RemoveFirst();
            //Partido();
        }

        //public static void Partido()
        //{
        //    Partido p = new Partido();
        //    for (int l = 0; l < equipoLocal.Count; l++)
        //    {
        //        p.EquipoLocal = equipoLocal.ElementAt(l);
                
        //    }
        //    for (int v = 0; v < equipoVisitante.Count; v++)
        //    {
        //        p.EquipoVisitante = equipoVisitante.ElementAt(v);
                
        //    }
        //    partido.Add(p.toString());
        //}
    }
}
