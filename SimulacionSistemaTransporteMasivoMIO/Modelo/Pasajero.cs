using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.Modelo
{
    public class Pasajero
    {
        /// <summary>
        /// Identificación del pasajero.
        /// </summary>
        private int Id;
        
        /// <summary>
        /// Parada en la cual se crea el pasajero en el sistema.
        /// </summary>
        private int EstOrigenId;

        /// <summary>
        /// Parada final a la cual debe llegar el pasajero para salir del sistema.
        /// </summary>
        private int EstDestinoId;

        /// <summary>
        /// La lista de eventos futuros de llegada de pasajeros determina la hora en la cual el pasajero ingresa al sistema.
        /// </summary>
        private int TiempoIngreso;

        /// <summary>
        /// Id de la estación en la cual se encuentra el pasajero, o la última estación en la que estuvo, en caso de que esté abordo de un bus.
        /// </summary>
        private int IdUltimaEstacion;

        /// <summary>
        /// Id del bus en el cual está a bordo el pasajero o el último bus en el que estuvo, en caso de que se encuentre en una estación. Si aún no ha
        /// abordado ningún bus, se asigna el valor -1.
        /// </summary>
        private int IdUltimoBus;

        /// <summary>
        /// Determina el estado en el cual se encuentra un pasajero:
        /// 1: Esperando Bus
        /// 2: A bordo de un bus
        /// 3: Esperando turno para entrar a una estación
        /// </summary>
        private int Estado;

        public Pasajero(int id, int stationSrcId, int stationDstId, int incomeTime) {
            EstOrigenId = stationSrcId;
            EstDestinoId = stationDstId;
            TiempoIngreso = incomeTime;
            Id = id;
        }

        public override string ToString()
        {
            
            return Id + " " + EstOrigenId + " " + EstDestinoId + " " + TiempoIngreso;
        }
        public int GetId() {
            return Id;
        }

        public int GetEstacionOrigenId()
        {
            return EstOrigenId;
        }

        public int GetEstacionDestinoId()
        {
            return EstDestinoId;
        }

        public int GetTiempoIngreso() {
            return TiempoIngreso;
        }

        public int GetIdUltimaEstacion()
        {
            return IdUltimaEstacion;
        }

        public int GetIdUltimoBus()
        {
            return IdUltimoBus;
        }

        public int GetEstado()
        {
            return Estado;
        }

        public void SetIdUltimaEstacion(int idEst) {
            IdUltimaEstacion = idEst;
        }

        public void SetIdUltimoBus(int idBus) {
            IdUltimoBus = idBus;
        }

        public void SetEstado(int estado) {
            Estado = estado;
        }

    }
}
