using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimulacionSistemaTransporteMasivoMIO.Modelo
{
    public class Estacion
    {
        private int Id;
        private String Nombre;
        private double Latitud;
        private double Longitud;
        private int Capacidad;
        private int DemandaActual;
        private List<Parada> Paradas;

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

        public int GetDemandaActual()
        {
            return DemandaActual;
        }
       
    }
}
