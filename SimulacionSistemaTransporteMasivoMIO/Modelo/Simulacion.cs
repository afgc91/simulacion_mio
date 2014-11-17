using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulacionSistemaTransporteMasivoMIO.TAD_s;
using SimulacionSistemaTransporteMasivoMIO.Almacenamiento;

namespace SimulacionSistemaTransporteMasivoMIO.Modelo
{
    public class Simulacion
    {
        /// <summary>
        /// Tiempo de operación entre semana.
        /// </summary>
        public static int SIM_TIME_WEEK=1080; //18 Horas. Desde las 05:00 hasta las 23:00

        /// <summary>
        /// Tiempo de operación los fines de semana y festivos.
        /// </summary>
        public static int SIM_TIME_WEEKEND = 960; //16 Horas. Desde las 6:00 hasta las 22:00

        /// <summary>
        /// Cantidad de milisegundos que equivalen a un minuto de simulación en tiempo real. Lo da el usuario.
        /// </summary>
        public int UnidadReloj;
        
        /// <summary>
        /// Reloj de la simulación.
        /// </summary>
        public int Timer;

        /// <summary>
        /// Pasajeros actualmente en el sistema.
        /// </summary>
        public List<Pasajero> Pasajeros;

        /// <summary>
        /// Estaciones en el sistema.
        /// </summary>
        public GrafoMatriz<Estacion> Estaciones;

        /// <summary>
        /// Total de buses en operación de Metrocali.
        /// </summary>
        public List<Bus> Buses;
        public Simulacion()
        {
            Estaciones = new GrafoMatriz<Estacion>();
            Pasajeros = new List<Pasajero>();
            Buses = new List<Bus>();
        }
        public void cargarEstaciones(List<Estacion> est)
        {
            for (int i = 0; i < est.Count; i++)
            {
                Estaciones.AgregarVertice(est[i]);
            }
        }

        public void cargarArcos(List<Arc> arcos)
        {

            Estacion[] a = Estaciones.DarVertices();
            for (int i = 0; i < arcos.Count; i++)
            {
                int inicio = -1;
                int fin = -1;
                for (int j = 0; j < a.Length && inicio == -1; j++)
                {

                    if (a[j].ContieneParada(arcos[i].StopIdStart))
                    {
                        inicio = j;
                    }

                }
                for (int k = 0; k < a.Length && fin == -1; k++)
                {
                    if (a[k].ContieneParada(arcos[i].StopIdEnd))
                    {
                        fin = k;
                    }
                }

                try
                {
                    Estaciones.AgregarArista(inicio, fin, arcos[i].ArcLenght);
                }
                catch (Exception)
                {

                }
            }
        }

        public void GenerarPasajeros()
        {
            Estacion[] a = Estaciones.DarVertices();

            for (int i = 0; i < a.Length; i++)
            {
                int cantidad = a[i].GetParadas().Count*307;

                Utilidades.GenerarPasajeros(cantidad, a.Length, 1080, a[i].GetId());
            }

        }

    }
}
