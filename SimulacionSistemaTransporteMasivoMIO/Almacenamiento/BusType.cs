using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.Almacenamiento
{
    public class BusType
    {
        /// <summary>
        /// Identificador de la clase BusTypeId.
        /// </summary>
        public int BusTypeId;

        public DateTime ShortName;
        public DateTime LongName;

        public BusType(int busTypeId, DateTime shortName, DateTime longName) {
            BusTypeId = busTypeId;
            ShortName = shortName;
            LongName = longName;
        }
    }
}
