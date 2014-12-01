using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulacionSistemaTransporteMasivoMIO.TAD_s;
using SimulacionSistemaTransporteMasivoMIO.TAD_s.ArregloColas;


namespace SimulacionSistemaTransporteMasivoMIO.Modelo
{
    public class Estacion
    {

        /// <summary>
        /// Id de la estación.
        /// </summary>
        private int Id;

        /// <summary>
        /// Nombre de la estación.
        /// </summary>
        private String Nombre;

        /// <summary>
        /// Latitud de la estación.
        /// </summary>
        private double Latitud;

        /// <summary>
        /// Longitud de la estación.
        /// </summary>
        private double Longitud;

        /// <summary>
        /// Capacidad de la estación.
        /// </summary>
        private int Capacidad;

        /// <summary>
        /// Lista de paradas de la estación.
        /// </summary>
        private List<Parada> Paradas;

        /// <summary>
        /// Lista de pasajeros que llegan a la estación.
        /// </summary>
        private List<Pasajero> Pasajeros;

        /// <summary>
        /// .
        /// </summary>
        private List<Ruta> RutasPosibles;

        /// <summary>
        /// Simulación a la que pertenece la estación.
        /// </summary>
        private Simulacion sim;

        /// <summary>
        /// Cantidad de pasajeros que puede alvergar una estación.
        /// </summary>
        private int CantidadPasajeros;

        private string[] datos;

        public Estacion(int id, String nombre, double latitud, double longitud, int capacidad, Simulacion sim)

        {
            this.sim = sim;
            Id = id;
            Nombre = nombre;
            Latitud = latitud;
            Longitud = longitud;
            Capacidad = capacidad;
            Paradas = new List<Parada>();
            Pasajeros = new List<Pasajero>();
            RutasPosibles = new List<Ruta>();
            CantidadPasajeros = 0;
            datos = new string[1100];
        }

        public void AumentarCantidadPasajeros(){
            CantidadPasajeros++;
        }

        public void agregarPasajeros(Pasajero p) {
            Pasajeros.Add(p);
        }

        public int DarCantidadPasajeros()
        {
            return CantidadPasajeros;
        }

        public int DarParadaEnEstacion(int paradaID)
        {
            for (int i = 0; i < Paradas.Count; i++)
            {
                if (Paradas[i].Id == paradaID)
                {
                    return i;
                }
            }
            return -1;
        }

        public int cantidadPasajerosEstacion()
        {
            int respuesta = 0;
            for (int i = 0; i < Paradas.Count; i++)
            {
                respuesta += Paradas[i].calcularCantidadPersonas();
            }
            return respuesta;
        }


        public  void AsignarRutasPosibles(Ruta ruta)
        {
            RutasPosibles.Add(ruta);
        }

        public bool AgregarParada(Parada p) {
            for (int a = 0; a < Paradas.Count; a++ ) {
                if(p.CompareTo(Paradas[a]) == 0){
                    return false;
                }
            }
            Paradas.Add(p);
            return true;
        }

        public bool ContieneParada(int paradaID)
        {
            for (int i = 0; i < Paradas.Count ; i++)
            {
                if (Paradas[i].Id == paradaID)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Permite generar los pasajeros de la estación y agregarlos a la lista de pasajeros de la estación, desde donde son enviados a la cola de su ruta correspondiente.
        /// Precondición: Lista de eventos futuros de pasajeros existe.
        /// </summary>
        /// <param name="tiempo"></param>
        /// <param name="grafo"></param>
        /// <returns></returns>
        public void AtiendeEstacion(int tiempo, GrafoMatriz<Estacion> grafo)
        {

            LeerPasajeros(tiempo);

            for (int i = 0; i < Pasajeros.Count; i++)
            {
                int dest = Pasajeros[i].GetEstacionDestinoId();
                //bool encontro = true;
              Queue<Pasajero>  posible = null;
                for (int j = 0; j < RutasPosibles.Count; j++)
                {
                    for (int k = 0; k < RutasPosibles[j].DarParadas().Count ; k++)
                    {
                        if (this.Id == RutasPosibles[j].DarParadas()[k][0])
                        {
                            if (grafo.DarMatriz()[k, dest] > grafo.DarMatriz()[k + 1, dest])
                            {
                                //Paradas[RutasPosibles[j].DarParadas()[k][1]].ColasPasajeros.AgregarElemento(Pasajeros[i], RutasPosibles[j].DarParadas()[k][2]);
                                //Pasajeros.RemoveAt(i);
                                if (posible == null)
                                {
                                    posible = Paradas[RutasPosibles[j].DarParadas()[k][1]].ColasPasajeros.ObtenerCola(RutasPosibles[j].DarParadas()[k][2]);
                                }else
                                if (Paradas[RutasPosibles[j].DarParadas()[k][1]].ColasPasajeros.TamanoCola(RutasPosibles[j].DarParadas()[k][2]) < posible.Count)
                                {
                                    posible = Paradas[RutasPosibles[j].DarParadas()[k][1]].ColasPasajeros.ObtenerCola(RutasPosibles[j].DarParadas()[k][2]);
                                }
                                //encontro = false;
                                
                            } 
                        }
                    }
                }
                if (posible != null)
                {
                    posible.Enqueue(Pasajeros[i]);
                    Pasajeros.RemoveAt(i);
                }
            }


            string cadena = "";
            for (int i = 0; i < Paradas.Count; i++)
            {
                cadena += "Parada numero: " + i + " ";
                for (int j = 0; j < Paradas[i].ColasPasajeros.DarTamano(); j++)
                {
                    if (Paradas[i].ColasPasajeros.colaEnUso(j))
                    {
                        cadena += "Cantidad cola " + j + ": " + Paradas[i].ColasPasajeros.TamanoCola(j) + " ";
                    }
                }
                cadena += "|| ";
            }
            cadena += "Cantidad pasajeros Historico : " + CantidadPasajeros +" Cantidad pasajeros Actual " + cantidadPasajerosEstacion() + " Cantidad pasajeros lista: " + Pasajeros.Count;

            //cadena = this.Nombre;
            //for (int i = 0; i < RutasPosibles.Count; i++)
            //{
            //   cadena +=  RutasPosibles[i].GetNombre();
            //}
            datos[tiempo] = cadena;

                Utilidades.ExportarInfo(datos, @"InformacionEst\" +this.Nombre, Id);
        }
        public void LeerPasajeros(int tiempo)
        {
            System.IO.StreamReader lector = new System.IO.StreamReader(@"..\\..\\Almacenamiento\Pasajeros\estacion" + Id + ".txt");
            String linea = lector.ReadLine();
            string[] datosUno = linea.Split(' ');
            String comp = datosUno[0];
            int comp1 = Int32.Parse(comp);
            while (comp1<=tiempo)
            {
                if (comp1 == tiempo)
                {
                    Pasajero pas = new Pasajero(Int32.Parse(datosUno[1]), Int32.Parse(datosUno[2]), Int32.Parse(datosUno[3]), Int32.Parse(datosUno[0]));
                    Pasajeros.Add(pas);
                }
                linea = lector.ReadLine();
                datosUno = linea.Split(' ');
                comp = datosUno[0];
                comp1 = Int32.Parse(comp);
                CantidadPasajeros++;
            }

        }

        public void Run()
        {
            int tiempo = sim.UnidadReloj;
            int duracion = sim.Timer;
            while (tiempo != duracion)
            {
                AtiendeEstacion(tiempo, sim.Estaciones);
            }
        }

        public int GetId() {
            return Id;
        }

        public String GetNombre() {
            return Nombre;
        }

        public double GetLatitud() {
            return Latitud;
        }

        public double GetLongitud() {
            return Longitud;
        }

        public int GetCapacidad() {
            return Capacidad;
        }

        public List<Parada> GetParadas() {
            return Paradas;
        }

       
        public void SetLatitud(double lat) {
            Latitud = lat;
        }

        public void SetLongitud(double lng)
        {
            Longitud = lng;
        }

        public void SetCapacidad(int cap) {
            Capacidad = cap;
        }
        public List<Parada> DarParadas()
        {
            return Paradas;
        }
    }
}
