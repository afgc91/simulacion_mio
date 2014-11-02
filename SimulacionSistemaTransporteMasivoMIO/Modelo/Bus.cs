using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.Modelo
{
    public class Bus
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

        /// <summary>
        /// Capacidad de un bus articulado.
        /// </summary>
        private static int CAPACIDAD_ARTICULADO=160;

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

        public Bus(int id, int tipoBus) {
            Id = id;
            TipoBus = tipoBus;
            switch (tipoBus) { 
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
        }

        public int GetId() {
            return Id;
        }

        public int GetTipoBus() {
            return TipoBus;
        }

        public int GetCapacidad() {
            return Capacidad;
        }
    }
}
