using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class MaquinaCambio
    {
        public int ObtenerSaldoMaquina()
        {
            return Datos.monedas.Sum(s => s.valor * s.cantidad);
        }

        public List<Moneda> ObtenerCambio(Moneda moneda)
        {
            List<Moneda> cambio = new List<Moneda>();
            Moneda cambioMoneda = new Moneda { valor = 0, cantidad = 0 };
            int posicionMoneda = 0;
            int valorMoneda = -1;
            int cantidadMoneda = 0;
            int resultadoMoneda = 0;

            foreach(Moneda m in Datos.monedas)
            {
                if(m.valor == moneda.valor)
                {
                    posicionMoneda = Datos.monedas.IndexOf(m);
                }
            }

            int posicionMonedaOficial = posicionMoneda;

            while(posicionMoneda < Datos.monedas.Count && valorMoneda != 0)
            {
                int c = posicionMoneda + 1;
                cambio.Clear();
                valorMoneda = moneda.valor;

                while (c < Datos.monedas.Count && valorMoneda != 0)
                {
                    if(Datos.monedas.ElementAt(c).cantidad > 0)
                    {
                        cantidadMoneda = valorMoneda / Datos.monedas.ElementAt(c).valor;
                        if(cantidadMoneda <= Datos.monedas.ElementAt(c).cantidad)
                        {
                            resultadoMoneda = cantidadMoneda * Datos.monedas.ElementAt(c).valor;
                            valorMoneda = valorMoneda - resultadoMoneda;
                        }
                        else
                        {
                            resultadoMoneda = Datos.monedas.ElementAt(c).ObtenerCantidad();
                            valorMoneda = valorMoneda - resultadoMoneda;
                            cantidadMoneda = Datos.monedas.ElementAt(c).cantidad;
                        }
                        cambioMoneda.valor = Datos.monedas.ElementAt(c).valor;
                        cambioMoneda.cantidad = cantidadMoneda;
                        cambio.Add(cambioMoneda);
                    }
                    c++;
                }
                posicionMoneda++;
            }

            if(valorMoneda != 0)
            {
                cambio.Clear();
            }

            foreach(Moneda m in cambio)
            {
                Datos.monedas.Find(c => c.valor == m.valor).cantidad = Datos.monedas.Find(c => c.valor == m.valor).cantidad - m.cantidad;
            }

            Datos.monedas.ElementAt(posicionMonedaOficial).cantidad++;
            return cambio;
        }
    }
}
