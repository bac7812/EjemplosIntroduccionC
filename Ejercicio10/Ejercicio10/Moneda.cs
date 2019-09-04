using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Moneda
    {
        public int valor { get; set; }
        public int cantidad { get; set; }

        public void AnadirNumMonedas(int cantidad)
        {
            this.cantidad += cantidad;
        }

        public void DisminuirMonedas(int cantidad)
        {
            this.cantidad -= cantidad;
        }

        public int ObtenerCantidad()
        {
            return valor * cantidad;
        }
    }
}
