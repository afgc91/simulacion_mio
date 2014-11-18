using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulacionSistemaTransporteMasivoMIO.TAD_s;
using SimulacionSistemaTransporteMasivoMIO.TAD_s.ArregloColas;

namespace SimulacionSistemaTransporteMasivoMIO.Modelo
{
    public class Bus
    {
        /// <summary>
        /// Identificador del bus.
        /// </summary>
        private int Id;
        
        /// <summary>
        /// Tipo del bus:
        /// 1. Articulado
        /// 2. Pre troncal
        /// 3. Alimentador
        /// </summary>
        private int TipoBus;

        /// <summary>
        /// Capacidad de un bus articulado.
        /// </summary>
        private static int CAPACIDAD_ARTICULADO=160;

        /// <summary>
        /// Capacidad de un bus pre troncal.
        /// </summary>
        private static int CAPACIDAD_PRE_TRONCAL = 80;

        /// <summary>
        /// Capacidad de un bus alimentador.
        /// </summary>
        private static int CAPACIDAD_ALIMENTADOR = 40;

        /// <summary>
        /// Capacidad del bus.
        /// </summary>
        private int Capacidad;

        private int CapacidadActual;

        private int EstacionActual;

        private Pasajero[] Pasajeros;

        private Ruta ruta;

        public Bus(int id, int tipoBus, Ruta ruta) {
            Id = id;
            TipoBus = tipoBus;
            this.ruta = ruta;
            switch (tipoBus) { 
                case 1:
                    Capacidad = CAPACIDAD_ARTICULADO;
                    break;
                case 2:
                    Capacidad = CAPACIDAD_PRE_TRONCAL;
                    break;
                case 3:
                    Capacidad = CAPACIDAD_ALIMENTADOR;
                    break;
            }
            Pasajeros = new Pasajero[Capacidad];
            CapacidadActual = 0;
        }

        public void Run(int tiempo, GrafoMatriz<Estacion> grafo)
        {

            Estacion[] estaciones = grafo.DarVertices();
            int EstacionActualRuta = ruta.DarParadas()[EstacionActual][0];
            int NumParada = ruta.DarParadas()[EstacionActual][1];
            int NumCola = ruta.DarParadas()[EstacionActual][2];
            for (int i = 0; i < Pasajeros.Length; i++)
            {
                if (Pasajeros[i] != null)
                {
                    if (Pasajeros[i].EsMiEstacion(EstacionActual,this,grafo) == 4)
                    {
                        Pasajeros[i] = null;
                        CapacidadActual--;
                    }
                    else if (Pasajeros[i].EsMiEstacion(EstacionActual, this, grafo) == 1)
                    {

                        estaciones[EstacionActual].agregarPasajeros(Pasajeros[i]);
                        Pasajeros[i] = null;
                        CapacidadActual--;

                    }
                }
            }

            Estacion estacion = estaciones[EstacionActualRuta];
            Parada parada = estacion.DarParadas()[NumParada];
               ArregloCola<Pasajero> pasajeros = parada.Pasajeros;
               while (!pasajeros.ColaVacia(NumCola) && CapacidadActual< Pasajeros.Length)
               {
                   agregarPasajero(pasajeros.ObtenerElemento(NumCola));
                   pasajeros.EliminarElemento(NumCola);
               }

         
            EstacionActual++;


        }
        public void agregarPasajero(Pasajero p)
        {
            bool agrego = false;
            for (int i = 0; i < Pasajeros.Length && !agrego; i++)
            {
                if (Pasajeros[i] == null)
                {
                    Pasajeros[i] = p;
                    agrego = true;
                }
            }
        }

        public int GetId() {
            return Id;
        }

        public int GetTipoBus() {
            return TipoBus;
        }

        public int GetCapacidad() {
            return Capacidad;
        }

        public Ruta DarRuta()
        {
            return ruta;
        }
        public int EstacionAct()
        {
            return EstacionActual;
        }
    }
}
