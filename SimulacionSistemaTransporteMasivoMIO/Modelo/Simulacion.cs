using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulacionSistemaTransporteMasivoMIO.TAD_s;
using SimulacionSistemaTransporteMasivoMIO.Almacenamiento;
using SimulacionSistemaTransporteMasivoMIO.TAD_s.ArregloColas;

namespace SimulacionSistemaTransporteMasivoMIO.Modelo
{
    public class Simulacion
    {
        /// <summary>
        /// Tiempo de operación entre semana.
        /// </summary>
        public static int SIM_TIME_WEEK = 1080; //18 Horas. Desde las 05:00 hasta las 23:00.

        /// <summary>
        /// Tiempo de operación los fines de semana y festivos.
        /// </summary>
        public static int SIM_TIME_WEEKEND = 960; //16 Horas. Desde las 6:00 hasta las 22:00.

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
        public int cantidadMaxBuses;
        public List<Ruta> Rutas;
        private List<Trip> viajes;
        private int velocidadValle;
        private int velocidadPico;
        public int cantidadBuses;
        private int lineaActualBuses = 0;
        public Simulacion()
        {
            Estaciones = new GrafoMatriz<Estacion>();
            Pasajeros = new List<Pasajero>();
            Buses = new List<Bus>();
            Rutas = new List<Ruta>();
            viajes = new List<Trip>();
            Timer = 0;
            UnidadReloj = 1000;
            //CargarBuses();
        }

        public void setHoraPicoYValle(int valle, int pico)
        {
            velocidadPico = pico;
            velocidadValle = valle;
        }

        public void setCantidadBuses(int cantidad)
        {
            cantidadMaxBuses = cantidad;
        }

        public int totalPasajeros()
        {
            int total = 0;
            Estacion[] estaciones = Estaciones.DarVertices();
            for (int i = 0; i < estaciones.Length; i++)
            {
                total += estaciones[i].DarCantidadPasajeros();
            }
            return total;
        }

        private void CargarBuses()
        {
            System.IO.StringReader lector = new System.IO.StringReader(@"..\\..\\Almacenamiento\Buses\buses.txt");
            String linea = "";
            String[] datosBus = null;
            Ruta ruta = null;
            while (true)
            {
                linea = lector.ReadLine();
                if (linea == null || linea.Equals(""))
                {
                    break;
                }
                datosBus = linea.Split(' ');
                ruta = null;
                for (int j = 0; j < Rutas.Count && ruta == null; j++)
                {
                    if (Rutas[j].GetId() == (Int32.Parse(datosBus[1])) && Rutas[j].GetSentido() == Int32.Parse(datosBus[2]))
                    {
                        ruta = Rutas[j];
                    }
                }

                Bus bus = new Bus(Int32.Parse(datosBus[1]), Int32.Parse(datosBus[3]), ruta, Int32.Parse(datosBus[0]), this);
                bus.setVelocidadValleYPico(velocidadValle, velocidadPico);
                Buses.Add(bus);
                linea = lector.ReadLine();
                datosBus = linea.Split(' ');
            }
        }

        public void AtiendeSimulacion()
        {

            System.IO.StreamReader lector = new System.IO.StreamReader(@"..\\..\\Almacenamiento\Buses\buses.txt");
            String linea = lector.ReadLine();
            for (int i = 1; i < lineaActualBuses; i++)
            {
                linea = lector.ReadLine();
            }
            
            string[] datosUno = linea.Split(' ');
            String comp = datosUno[0];
            int comp1 = Int32.Parse(comp);
                while (comp1<= Timer && Buses.Count <= cantidadMaxBuses)
                {


                    Ruta ruta = null;
                    for (int j = 0; j < Rutas.Count && ruta == null; j++)
                    {
                        if (Rutas[j].GetId() == (Int32.Parse(datosUno[1])) && Rutas[j].GetSentido() == Int32.Parse(datosUno[2]))
                        {
                            ruta = Rutas[j];
                        }
                        lineaActualBuses++;
                    }

                    Bus bus = new Bus(Int32.Parse(datosUno[1]), Int32.Parse(datosUno[3]), ruta, Int32.Parse(datosUno[0]), this);
                    bus.setVelocidadValleYPico(velocidadValle, velocidadPico);
                    Buses.Add(bus);
                    linea = lector.ReadLine();
                    datosUno = linea.Split(' ');
                    comp = datosUno[0];
                }

        }

        public void StartSim()
        {
            //for (int i = 0; i < Estaciones.DarVertices().Length; i++)
            //{
            //    System.Threading.Thread hilo = new System.Threading.Thread(new System.Threading.ThreadStart(Estaciones.DarVertices()[i].Run));
            //    hilo.Start();
            //}
            while (Timer < SIM_TIME_WEEK)
            {


                AtiendeSimulacion();

                for (int i = 0; i < Estaciones.CantidadVertices(); i++)
                {
                    Estaciones.DarVertices()[i].AtiendeEstacion(Timer, Estaciones);
                }

                    for (int i = 0; i < Buses.Count; i++)
                    {
                        if (Buses[i].Eliminar())
                        {
                            Buses.RemoveAt(i);
                        }
                        Buses[i].AtiendeBus(Timer, Estaciones);
                    }

                    Console.WriteLine("Tiempo de simulación: " + Timer);
                Timer += 1;

                //System.Threading.Thread.Sleep(UnidadReloj);
            }
            Console.WriteLine("Terminó la simulación");
        }

        public void cargarEstaciones(List<Estacion> est)
        {
            for (int i = 0; i < est.Count; i++)
            {
                Estaciones.AgregarVertice(est[i]);
            }
        }

        public void cargarViajes(List<Trip> via)
        {
            List<Bus> buses = new List<Bus>();

            for (int i = 0; i < via.Count; i++)
            {
                int linea = via[i].LineId;
                int orientacion = via[i].Orientation;
                double momento = (Int32.Parse(via[i].StartTime)) / 3600;
                Ruta ruta = null;
                int tipo = 0;

                for (int j = 0; j < Rutas.Count && ruta == null; j++)
                {
                    if (Rutas[j].GetId().Equals(linea) && Rutas[j].GetSentido() == orientacion )
                    {
                        ruta = Rutas[j];
                    }
                }

                if (ruta.GetNombre().StartsWith("T") || ruta.GetNombre().StartsWith("E"))
                {
                    tipo = 1;
                }
                else if (ruta.GetNombre().StartsWith("P"))
                {
                    tipo = 2;
                }
                else
                {
                    tipo = 3;
                }

                Bus nuevo = new Bus(linea, tipo, ruta, momento, this);

                buses.Add(nuevo);
            }

            buses.Sort();

            List<string> buses1 = new List<string>();
            for (int i = 0; i < buses.Count; i++)
            {
                buses1.Add(buses[i].ToString());
            }

            System.IO.File.WriteAllLines(@"..\\..\\Almacenamiento\Buses\buses.txt", buses1);

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
                int cantidad = a[i].GetParadas().Count * 307;

                Utilidades.GenerarPasajeros(cantidad, 1080, a, i);
            }

        }
        public void CargarRutas(List<LineStop> paradas, List<Line> ruts)
        {
            Estacion[] esta = Estaciones.DarVertices();
     

            Ruta auxRut = null;
            int tempStopId = 0;
            int estacionNum = 0;
            int auxPa = 0;
            int auxIdCola = 0;
            int[] auxParada = null;
            
            for (int i = 0; i < ruts.Count; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    auxRut = new Ruta(ruts[i].LineId, k, ruts[i].ShortName + " " + k, ruts[i].Description);
                    List<int[]> ids = new List<int[]>();
                    for (int j = 0; j < paradas.Count; j++)
                    {

                        if (paradas[j].LineId == auxRut.GetId() && paradas[j].Orientation == auxRut.GetSentido())
                        {
                            tempStopId = paradas[j].StopId;
                            estacionNum = Utilidades.BuscarIndiceEstacion(esta, tempStopId);
                            if (estacionNum != -1)
                            {
                                auxPa = esta[estacionNum].DarParadaEnEstacion(tempStopId);
                                auxIdCola = asignarCola(ids, esta[estacionNum].DarParadas()[auxPa].ColasPasajeros, tempStopId);
                                //auxParada = { estacionNum, auxPa, auxIdCola };
                                auxParada = new int[3];
                                auxParada[0] = estacionNum;
                                auxParada[1] = auxPa;
                                auxParada[2] = auxIdCola;
                                auxRut.agregarParada(auxParada);
                            }


                        }
                    }

                    if (auxRut.DarParadas().Count > 0)
                    {

                        Rutas.Add(auxRut);

                    }
                    Console.WriteLine(auxRut.GetNombre() + " " + auxRut.DarParadas().Count);
                }
            }

            asignarRutas();
        }

       private void asignarRutas()
        {
            Estacion[] estaciones = Estaciones.DarVertices();

            for (int j = 0; j < Rutas.Count; j++)
            {
                for (int k = 0; k < Rutas[j].DarParadas().Count; k++)
                {

                    estaciones[Rutas[j].DarParadas()[k][0]].AsignarRutasPosibles(Rutas[j]);

                }
            }

        }

        private int asignarCola(List<int[]> ids, ArregloCola<Pasajero> cola, int stopId)
        {
            int retorno = -1;
            int auxRetorno = Contiene(ids, stopId);
            if (auxRetorno == -1)
            {
                for (int i = 0; i < cola.DarTamano() && retorno == -1; i++)
                {
                    if (!cola.colaEnUso(i))
                    {
                        cola.inicializarCola(i);
                        int[] auxAgrega = { stopId, i };
                        ids.Add(auxAgrega);
                        retorno = i;
                    }
                }
            }
            else
            {
                retorno = ids[auxRetorno][1];
            }

            return retorno;

        }

        private int Contiene(List<int[]> ids, int stopId)
        {
            int retorno = -1;
            for (int i = 0; i < ids.Count && retorno == -1; i++)
            {
                if (ids[i][0] == stopId)
                {
                    retorno = i;
                }
            }
            return retorno;
        }

    }
}
