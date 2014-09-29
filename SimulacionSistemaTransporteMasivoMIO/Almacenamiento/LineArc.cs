using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.Almacenamiento
{
    public class LineArc
    {
        public int LineArcId;
        public int LineId;
        public int ArcId;
        public int ArcSequence;
        public int Orientation;
        public int PlanVersionId;
        public Int16 LineVariant;
        public DateTime RegisterDate;

        public LineArc(int id, int lineId, int arcId, int arcSequence, int orientation, int planVersionId, Int16 lineVariant, DateTime register) {
            LineArcId = id;
            LineId = lineId;
            ArcId = arcId;
            ArcSequence = arcSequence;
            Orientation = orientation;
            PlanVersionId = planVersionId;
            LineVariant = lineVariant;
            RegisterDate = register;
        }
    }
}
