using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.Almacenamiento
{
    public class DataPlan
    {
        public int DataPlanId;
        public String LineShortName;
        public int LineId;
        public int Orientation;
        public int TotalStops;
        public int TripLenght;
        public int TaskId;
        public int TripId;
        public int TripStartTime;
        public int ScheduleTypeId;
        public int TripTypeId;
        public int PlanVersionId;
        public String TransportContratist;
        public DateTime RegisterDate;
        public int TripEndTime;
        public int TripTransitTime;

        public DataPlan(int id, String lineShortName, int lineId, int orientation, int totalStops, int tripLenght, int taskId, int tripId, int tripStartTime, int scheduleTypeId, int tripTypeId, int planVersionId, String contratist, DateTime register, int tripEndTime, int tripTransitTime) {
            DataPlanId = id;
            LineShortName = lineShortName;
            LineId = lineId;
            Orientation = orientation;
            TotalStops = totalStops;
            TripLenght = tripLenght;
            TaskId = taskId;
            TripId = tripId;
            TripStartTime = tripStartTime;
            ScheduleTypeId = scheduleTypeId;
            TripTypeId = tripTypeId;
            PlanVersionId = planVersionId;
            TransportContratist = contratist;
            RegisterDate = register;
            TripEndTime = tripEndTime;
            TripTransitTime = tripTransitTime;
        }
    }
}
