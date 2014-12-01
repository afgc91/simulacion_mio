using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulacionSistemaTransporteMasivoMIO.TAD_s;
using SimulacionSistemaTransporteMasivoMIO.TAD_s.ArregloColas;

namespace SimulacionSistemaTransporteMasivoMIO.Modelo
{
    public class Bus : IComparable
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

        private int VELOCIDAD_VALLE = 40;

        private int VELOCIDAD_PICO = 20;

        /// <summary>
        /// Capacidad de un bus articulado.
        /// </summary>
        private static int CAPACIDAD_ARTICULADO = 160;

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

        /// <summary>
        /// Capacidad en un momento dado del bus.
        /// </summary>
        private int CapacidadActual;

        /// <summary>
        /// Estacion en que se encuentra un bus en un momento determinado.
        /// </summary>
        private int EstacionActual;

        /// <summary>
        /// Momento en el que se realizara el siguiente evento en la simulacion.
        /// </summary>
        private int siguienteInteraccion;

        /// <summary>
        /// Arreglo de pasajeros que viajan en el bus.
        /// </summary>
        private Pasajero[] Pasajeros;

        /// <summary>
        /// Ruta de paradas que sigue el bus.
        /// </summary>
        private Ruta ruta;

        /// <summary>
        ///Simulacion a la que pertenece el bus.
        /// </summary>
        private Simulacion sim;

        /// <summary>
        /// Estado actual del bus
        /// false- No esta en una estación
        /// true- Esta en una estación
        /// </summary>
        private bool Estado;
        private bool TerminoRecorrido = false;


        private string[] datos;

        public bool Eliminar()
        {
            return TerminoRecorrido;
        }

        public Bus(int id, int tipoBus, Ruta ruta, double siguienteInteraccion, Simulacion sim)
        {
            this.sim = sim;
            Id = id;
            TipoBus = tipoBus;
            this.ruta = ruta;
            switch (tipoBus)
            {
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
            EstacionActual = 0;
            Pasajeros = new Pasajero[Capacidad];
            CapacidadActual = 0;
            this.siguienteInteraccion = normalizarATiempoSimulacion(siguienteInteraccion);
            datos = new string[1100];
        }

        public void setVelocidadValleYPico(int valle, int pico)
        {

            VELOCIDAD_PICO = pico;
            VELOCIDAD_VALLE = valle;

        }

        public override string ToString()
        {
            return siguienteInteraccion + " " + Id+ " " + ruta.GetSentido() + " " + TipoBus;
        }

        /// <summary>
        /// Permite realizar las operaciones del bus, que consiten en desenso de pasajeros, subir pasajeros y avanzar a otra estación.
        /// </summary>
        /// <param name="tiempo"></param>
        /// <param name="grafo"></param>
        /// <returns></returns>
        public void AtiendeBus(int tiempo, GrafoMatriz<Estacion> grafo)
        {
            if (tiempo == siguienteInteraccion)
            {
                Estacion[] estaciones = grafo.DarVertices();
                    
                

                int EstacionActualRuta = ruta.DarParadas()[EstacionActual][0];
                int NumParada = ruta.DarParadas()[EstacionActual][1];
                int NumCola = ruta.DarParadas()[EstacionActual][2];

                if (ruta.DarParadas().Count <= EstacionActual + 1)
                {
                    TerminoRecorrido = true;
                }
                Estacion estacion = estaciones[EstacionActualRuta];
                Parada parada = estacion.DarParadas()[NumParada];
                if (!parada.Estado && !Estado)
                {
                    parada.Estado = true;
                    this.Estado = true;
                    for (int i = 0; i < Pasajeros.Length; i++)
                    {
                        if (Pasajeros[i] != null)
                        {
                            if (Pasajeros[i].EsMiEstacion(EstacionActual, this, grafo) == 4)
                            {
                                Pasajeros[i] = null;
                                CapacidadActual--;
                            }
                            else if (Pasajeros[i].EsMiEstacion(EstacionActual, this, grafo) == 1)
                            {

                                estaciones[EstacionActual].agregarPasajeros(Pasajeros[i]);
                                estaciones[EstacionActual].AumentarCantidadPasajeros();
                                Pasajeros[i] = null;
                                CapacidadActual--;

                            }
                        }
                    }

                   
                    ArregloCola<Pasajero> pasajeros = parada.ColasPasajeros;

                    while (!pasajeros.ColaVacia(NumCola) && CapacidadActual < Capacidad)
                    {
                        agregarPasajero(pasajeros.ObtenerElemento(NumCola));
                        pasajeros.EliminarElemento(NumCola);
                        CapacidadActual++;
                    }

                    siguienteInteraccion++;
                    datos[tiempo] = "Nombre estación: " + grafo.DarVertices()[EstacionActualRuta].GetNombre() + " Siguiente interacción: " + siguienteInteraccion + " Cantidad pasajeros: " + CapacidadActual +" Tiempo Actual: " + tiempo + " Numero parada: " + NumParada + " Cola: " + NumCola;
                   
                }
                else if (Estado)
                {
                    datos[tiempo] = "Atiende";
                    parada.Estado = false;
                    this.Estado = false;
                    EstacionActual++;
                    if ((tiempo > 120 && tiempo < 240) || (tiempo > 780 && tiempo < 900))
                    {
                        siguienteInteraccion += (int)(grafo.DarMatriz()[EstacionActualRuta, ruta.DarParadas()[EstacionActual][0]] / VELOCIDAD_PICO);

                    }
                    else
                    {
                        //Console.WriteLine(ruta.DarParadas()[EstacionActual][0]);
                        //Console.WriteLine(grafo.DarMatriz()[EstacionActualRuta, ruta.DarParadas()[EstacionActual][0]]);
                        siguienteInteraccion += (int)(grafo.DarMatriz()[EstacionActualRuta, ruta.DarParadas()[EstacionActual][0]] / VELOCIDAD_VALLE);

                    }

                    
                }
                else
                {
                    datos[tiempo] = "Espera Atención";
                    siguienteInteraccion++;
                }

                
                
                
            }
            else
            {
                datos[tiempo] = "Espera";
            }
            Utilidades.ExportarInfo(datos, @"Informacion\bus" + this.ruta.GetNombre()+" ", this.GetHashCode());


        }

        /// <summary>
        /// Permite transformar los valores de hora en que parten los buses a tiempo de simulación.
        /// Precondición: existe una hora  de partida del bus.
        /// </summary>
        /// <param name="tOrigen"></param>
        /// <returns>int tNor</returns>
        public int normalizarATiempoSimulacion(double tOrigen)
        {
            int tNor = 0;

            if (tOrigen < 5)
            {
                tOrigen = 5;
            }
            if (tOrigen > 22)
            {
                tOrigen = 22;
            }
            int ent = (int)tOrigen;
            int dec = (int)((tOrigen - ent) * 60);

            if (ent == 5)
            {
                tNor = 0;
            }
            if (ent > 5)
            {
                int dif = ent - 5;
                tNor += dif * (60);
            }

            tNor = tNor + dec;
            return tNor;
        }

        public void Run(int duracion, int tiempo, GrafoMatriz<Estacion> estaciones)
        {
            while (tiempo != duracion)
            {
                AtiendeBus(tiempo, estaciones);
            }
        }

        public void Run()
        {
            int tiempo = sim.Timer;
            int duracion = Simulacion.SIM_TIME_WEEK;
            while (tiempo < duracion)
            {
                tiempo = sim.Timer;
                AtiendeBus(tiempo, sim.Estaciones);
            }
            Console.WriteLine("Finalizo Bus");
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

        public int GetId()
        {
            return Id;
        }

        public int GetTipoBus()
        {
            return TipoBus;
        }

        public int GetCapacidad()
        {
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

        public int CompareTo(object obj)
        {
            Bus a = (Bus)obj;
            return siguienteInteraccion.CompareTo(a.siguienteInteraccion);
        }
    }
}
