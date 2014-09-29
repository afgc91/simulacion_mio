using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.Almacenamiento
{
    public class TripType
    {
        public int TripTypeId;
        public String TripDescription;

        public TripType(int id, String desc) {
            TripTypeId = id;
            TripDescription = desc;
        }
    }
}
