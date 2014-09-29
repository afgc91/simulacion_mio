using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.Almacenamiento
{
    public class Arc
    {
        public int ArcId;
        public int PlanVersionId;
        public int StopIdStart;
        public int StopIdEnd;
        public String StartPoint;
        public String EndPoint;
        public String Description;
        public int ArcLenght;

        public Arc(int id, int planVersionId, int start, int end, String startPoint, String endPoint, String desc, int lenght) {
            ArcId = id;
            PlanVersionId = planVersionId;
            StopIdStart = start;
            StopIdEnd = end;
            StartPoint = startPoint;
            EndPoint = endPoint;
            Description = desc;
            ArcLenght = lenght;
        }
    }
}
