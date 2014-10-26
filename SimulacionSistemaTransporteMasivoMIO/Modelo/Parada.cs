using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.Modelo
{
    public class Parada
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
        public long Latitud;
        
        /// <summary>
        /// Longitud para definir la ubicación geográfica.
        /// </summary>
        public long Longitud;
        
        /// <summary>
        /// Estado en el que se encuentra la parada. Los estados pueden ser:
        /// 1. No hay buses.
        /// 2. Hay un bus y hay pasajeros abordando.
        /// 3. Hay un bus y hay pasajeros desembarcando.
        /// </summary>
        public Int16 Estado;

        /// <summary>
        /// Id del bus actual o del último bus que visitó la parada.
        /// </summary>
        public int IdUltimoBus;

        public Parada() {
            Id = 0;
            EstacionId = 0;
            Nombre = "";
            Latitud = 0;
            Longitud = 0;
            Estado = 0;
            IdUltimoBus = 0;
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

        public void SetEstado(Int16 estado)
        {
            Estado = estado;
        }

        public void SetIdUltimoBus(int busId)
        {
            IdUltimoBus = busId;
        }
    }
}
