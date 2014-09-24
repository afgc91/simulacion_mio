using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.Modelo
{
    public class CalendarMIO
    {
        public int CalendarId;
        public DateTime OperationDate;
        public int ScheduleTypeId;
        public int PlanVersionId;

        public CalendarMIO(int id, DateTime date, int scheduleTypeId, int planVersionId) {
            CalendarId = id;
            OperationDate = date;
            ScheduleTypeId = scheduleTypeId;
            PlanVersionId = planVersionId;
        }
    }
}
