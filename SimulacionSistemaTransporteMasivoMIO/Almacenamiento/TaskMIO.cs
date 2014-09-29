using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.Almacenamiento
{
    public class TaskMIO
    {
        public int TaskId;
        public int ScheduleTypeId;
        public int LineId;
        public int PlanVersionId;

        public TaskMIO(int id, int scheduleTypeId, int lineId, int planVersionId) {
            TaskId = id;
            ScheduleTypeId = scheduleTypeId;
            LineId = lineId;
            PlanVersionId = planVersionId;
        }
    }
}
