using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.Modelo
{
    public class Ruta
    {
        /// <summary>
        /// Identificador de la ruta.
        /// </summary>
        public int Id;

        /// <summary>
        /// Sentido de la ruta:
        /// 1: Ida
        /// 2: Vuelta
        /// </summary>
        public int Sentido;

        /// <summary>
        /// Nombre de la ruta.
        /// </summary>
        public String Nombre;

        /// <summary>
        /// Descripción de la ruta.
        /// </summary>
        public String Descripcion;

        public Ruta(int id, int sentido, String nombre, String desc) {
            Id = id;
            Nombre = nombre;
            Descripcion = desc;
        }
    }
}
