using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimulacionSistemaTransporteMasivoMIO.Modelo
{
    public class Estacion
    {
        public int Id;
        public String Nombre;
        public double Latitud;
        public double Longitud;
        public int Capacidad;
        public int DemandaActual;
        public List<Parada> Paradas;

        public Estacion(int id, String nombre, double latitud, double longitud, int capacidad)
        {
            Id = id;
            Nombre = nombre;
            Latitud = latitud;
            Longitud = longitud;
            Capacidad = capacidad;
            Paradas = new List<Parada>();
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
       
    }
}
