using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.Almacenamiento
{
    public class ScheduleType
    {
        public int ScheduleTypeId;
        public int PlanVersionId;
        public String ShortName;
        public String Description;

        public ScheduleType(int id, int planVersionId, String shortName, String desc) {
            ScheduleTypeId = id;
            PlanVersionId = planVersionId;
            ShortName = shortName;
            Description = desc;
        }
    }
}
