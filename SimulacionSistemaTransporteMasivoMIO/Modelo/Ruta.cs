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
        private int Id;

        /// <summary>
        /// Sentido de la ruta:
        /// 1: Ida
        /// 2: Vuelta
        /// </summary>
        private int Sentido;

        /// <summary>
        /// Nombre de la ruta.
        /// </summary>
        private String Nombre;

        /// <summary>
        /// Descripción de la ruta.
        /// </summary>
        private String Descripcion;

        /// <summary>
        /// Lista que representa las paradas de la ruta.
        /// </summary>
        private List<int[]> ParadasRut;

        public Ruta(int id, int sentido, String nombre, String desc) {
            Id = id;
            Nombre = nombre;
            Descripcion = desc;
            Sentido = sentido;
            ParadasRut = new List<int[]>();
        }

        public void agregarParada(int[] parada)
        {
            ParadasRut.Add(parada);
        }

        public int GetId() {
            return Id;
        }

        public int GetSentido()
        {
            return Sentido;
        }

        public String GetNombre()
        {
            return Nombre;
        }

        public String GetDescripcion()
        {
            return Descripcion;
        }

        public List<int[]> DarParadas()
        {
            return ParadasRut;
        }

    }
}
