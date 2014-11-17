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
        public static int SIM_TIME_WEEK = 1080; //18 Horas. Desde las 05:00 hasta las 23:00

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
        public GrafoMatriz<Estacion> GrafoMIO;

        /// <summary>
        /// Total de buses en operación de Metrocali.
        /// </summary>
        public List<Bus> Buses;
        public Simulacion()
        {
            GrafoMIO = new GrafoMatriz<Estacion>();
            Pasajeros = new List<Pasajero>();
            Buses = new List<Bus>();
        }
        public void CargarEstaciones(List<Estacion> est)
        {
            for (int i = 0; i < est.Count; i++)
            {
                GrafoMIO.AgregarVertice(est[i]);
            }
        }
        public void CargarArcos(List<Arc> arcos)
        {
            int omitidos = 0;
            Estacion[] estaciones = GrafoMIO.DarVertices();
            Console.WriteLine("Cantidad de vértices cargados: "+estaciones.Length);
            for (int i = 0; i < arcos.Count; i++)
            {
                if (arcos[i].StartPoint.Contains("UNIVAL") || arcos[i].EndPoint.Contains("UNIVAL")) {
                    Console.WriteLine("Recibió un arco con Univalle - Inicio: " + arcos[i].StartPoint + " Fin: " + arcos[i].EndPoint);
                }
                Estacion inicio = null;
                Estacion fin = null;
                for (int j = 0; j < estaciones.Length && inicio == null; j++)
                {
                    if (estaciones[j].ContieneParada(arcos[i].StopIdStart))
                    {
                        inicio = estaciones[j];
                    }
                }
                for (int j = 0; j < estaciones.Length && fin == null; j++)
                {
                    if (estaciones[j].ContieneParada(arcos[i].StopIdEnd))
                    {
                        fin = estaciones[j];
                    }
                }

                try
                {
                    GrafoMIO.AgregarArista(inicio, fin, arcos[i].ArcLenght);
                    if (arcos[i].StartPoint.Contains("UNIVAL") || arcos[i].EndPoint.Contains("UNIVAL")) {
                        Console.WriteLine("Se cargó un arco con Univalle");
                    }
                }
                catch (Exception)
                {
                    omitidos += 1;
                    //Console.WriteLine("arco: " + inicio.GetNombre() + " " + fin.GetNombre());
                }
            }
            Console.WriteLine("Se cargaron " + (arcos.Count - omitidos) + " arcos de un total de " + arcos.Count);
            //List<Estacion> c = GrafoMIO.BFS(estaciones[44]);
            //Console.WriteLine(GrafoMIO.CantidadVertices());
            //Console.WriteLine(c.Count);
            //for (int i = 0; i < c.Count; i++)
            //{
                //Console.WriteLine(c[i].GetNombre() + " " + GrafoMIO.DarVertices()[i].GetNombre());
            //}
        }

        public void CargarAristas() {
            Estacion[] estaciones = GrafoMIO.DarVertices();

        }

    }
}
