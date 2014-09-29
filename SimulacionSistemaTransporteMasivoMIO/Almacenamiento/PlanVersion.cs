using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.Almacenamiento
{
    public class PlanVersion
    {
        /// <summary>
        /// Identificador de la clase PlanVersion.
        /// </summary>
        public int PlanVersionId;
       
        public DateTime ActivationDate;
        public TimeSpan CreationDate;

        public PlanVersion(int planVersionId, DateTime activationDate, TimeSpan creationDate) {
            PlanVersionId = planVersionId;
            ActivationDate = activationDate;
            CreationDate = creationDate;
        }
    }
}
