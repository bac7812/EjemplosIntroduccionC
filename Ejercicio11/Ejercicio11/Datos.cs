using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Cita
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NombreCompleto
        {
            get
            {
                return Nombre + " " + Apellidos;
            }
        }
        public DateTime FechaCita { get; set; }

        public string Dia
        {
            get
            {
                CultureInfo cultInfo = new CultureInfo("es-ES");
                return cultInfo.DateTimeFormat.GetDayName(FechaCita.DayOfWeek);
            }
        }

        public int Hora { get; set; }
        public int Minutos { get; set; }
        public string Horario
        {
            get
            {
                return Hora + ":" + Minutos;
            }
        }
    }
    public class Datos
    {
        public static List<Cita> listaCitas = new List<Cita>() {
            new Cita { Nombre = "Carlos", Apellidos= "González Rodríguez", FechaCita=new DateTime(2017,12,10,0,0,0), Hora=10, Minutos=15 },
            new Cita { Nombre = "Luis", Apellidos= "Gómez Fernández", FechaCita=new DateTime(2017,10,12,0,0,0), Hora=11, Minutos=15  },
            new Cita { Nombre = "Ana", Apellidos= "López Díaz", FechaCita=new DateTime(2017,10,15,0,0,0), Hora=10, Minutos=15 },
            new Cita { Nombre = "Fernando", Apellidos= "Martínez Pérez", FechaCita=new DateTime(2017,10,21,0,0,0), Hora=12, Minutos=15  },
            new Cita { Nombre = "Lucia", Apellidos= "Garcia Sánchez", FechaCita=new DateTime(2017,10,25,0,0,0), Hora=10, Minutos=30  },
            new Cita { Nombre = "Belen", Apellidos= "Gómez Diz", FechaCita=new DateTime(2017,11,4,0,0,0), Hora=10, Minutos=15  },
            new Cita { Nombre = "Juan", Apellidos= "Gómez Sánchez", FechaCita=new DateTime(2017,11,4,0,0,0), Hora=12, Minutos=15  },
            new Cita { Nombre = "Rodrigo", Apellidos= "Alvárez Pérez", FechaCita=new DateTime(201,11,19,0,0,0), Hora=10, Minutos=30 },
        };
    }
}
