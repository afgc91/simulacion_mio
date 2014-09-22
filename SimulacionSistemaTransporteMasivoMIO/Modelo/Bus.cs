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
        /// Identificador de la clase bus.
        /// </summary>
        public int BusId;
        
        /// <summary>
        /// Número del bus.
        /// </summary>
        public int BusNumber;

        public String Identification;
        
        /// <summary>
        /// Identificador del tipo de bus al cual pertenece el bus.
        /// </summary>
        public int BusTypeId;

        /// <summary>
        /// Identificador de la instancia de PlanVersion a la cual perternece el bus.
        /// </summary>
        public int PlanVersionId;

        public Bus(int busId, int busNumber, String identification, int busTypeId, int planVersionId) {
            BusId = busId;
            BusNumber = busNumber;
            Identification = identification;
            BusTypeId = busTypeId;
            PlanVersionId = planVersionId;
        }
    }
}
