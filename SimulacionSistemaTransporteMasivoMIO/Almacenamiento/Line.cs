using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.Almacenamiento
{
    public class Line
    {
        public int LineId;
        public int PlanVersionId;
        public String ShortName;
        public String Description;

        public Line(int id, int planVersionId, String shortName, String desc) {
            LineId = id;
            PlanVersionId = planVersionId;
            ShortName = shortName;
            Description = desc;
        }
    }
}
