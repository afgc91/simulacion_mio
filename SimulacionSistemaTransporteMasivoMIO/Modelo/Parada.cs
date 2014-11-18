using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulacionSistemaTransporteMasivoMIO.TAD_s.ArregloColas;

namespace SimulacionSistemaTransporteMasivoMIO.Modelo
{
    public class Parada : IComparable
    {
        /// <summary>
        /// Id de la parada.
        /// </summary>
        public int Id;
        
        /// <summary>
        /// Id de la estación a la cual pertenece la parada.
        /// </summary>
        public int EstacionId;
        
        /// <summary>
        /// Nombre de la parada o vagón (e.g. A1, B2, C1, etc.)
        /// </summary>
        public String Nombre;
        
        /// <summary>
        /// Latitud para definir la ubicación geográfica.
        /// </summary>
        public double Latitud;
        
        /// <summary>
        /// Longitud para definir la ubicación geográfica.
        /// </summary>
        public double Longitud;
        
        /// <summary>
        /// Estado en el que se encuentra la parada. Los estados pueden ser:
        /// false No hay buses.
        /// true Hay un bus y hay pasajeros abordando.
        /// </summary>
        public bool Estado;

        /// <summary>
        /// Id del bus actual o del último bus que visitó la parada.
        /// </summary>
        public int IdUltimoBus;

        public ArregloCola<Pasajero> Pasajeros;

        public Parada(int id, String nombre, double latitud, double longitud) {
            Id = id;
            Nombre = nombre;
            Latitud = latitud;
            Longitud = longitud;
            Estado = false;
            IdUltimoBus = 0;
            Pasajeros = new ArregloCola<Pasajero>(6);
        }

        public bool Ocupada()
        {
            return Estado;
        }

        public void SetId(int id) {
            Id = id;
        }

        public void SetEstacionId(int estacionId)
        {
            EstacionId = estacionId;
        }

        public void SetNombre(String nombre)
        {
            Nombre = nombre;
        }

        public void SetLatitud(long latitud)
        {
            Latitud = latitud;
        }

        public void SetLongitud(long longitud)
        {
            Longitud = longitud;
        }

        public void SetEstado(bool estado)
        {
            Estado = estado;
        }

        public void SetIdUltimoBus(int busId)
        {
            IdUltimoBus = busId;
        }

        public int CompareTo(object obj)
        {
           Parada a = (Parada)obj;
           return a.Nombre.CompareTo(this.Nombre);
        }
    }
}
