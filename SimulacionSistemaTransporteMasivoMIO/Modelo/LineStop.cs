using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.Modelo
{
    public class LineStop
    {
        public int LineStopId;
        public int StopSequence;
        public Int16 Orientation;
        public int LineId;
        public int StopId;
        public int PlanVersionId;
        public int LineVariant;
        public DateTime RegisterDate;
        public int LineVariantType;

        public LineStop(int id, int stopSeq, Int16 orientation, int lineId, int stopId, int planVersionId, int lineVariant, DateTime register, int lineVariantType) {
            LineStopId = id;
            StopSequence = stopSeq;
            Orientation = orientation;
            LineId = lineId;
            StopId = stopId;
            PlanVersionId = planVersionId;
            LineVariant = lineVariant;
            LineVariantType = lineVariantType;
            RegisterDate = register;
        }
    }
}
