using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.Almacenamiento
{
    public class Trip
    {
        public int Id;
        public int TripId;
        public int PlanVersionId;
        public int TripTypeId;
        public int ScheduleTypeId;
        public int TripSequence;
        public String StartTime;
        public int TaskId;
        public int LineId;
        public int StartStopId;
        public int EndStopId;
        public String Description;
        public int Orientation;
        public int LineVariant;
        public DateTime RegisterDate;
        public int ScheduleProfileId;

        public Trip(int id, int tripId, int planVersionId, int tripTypeId, int scheduleTypeId, int tripSeq, String startTime, int taskId, int lineId, int startStopId, int endStopId, String desc, int orientation, int lineVariant, DateTime register, int scheduleProfileId) {
            TripId = tripId;
            Id = id;
            PlanVersionId = planVersionId;
            TripTypeId = tripTypeId;
            ScheduleTypeId = scheduleTypeId;
            TripSequence = tripSeq;
            StartTime = startTime;
            TaskId = taskId;
            LineId = lineId;
            startStopId = StartStopId;
            EndStopId = endStopId;
            Description = desc;
            Orientation = orientation;
            LineVariant = lineVariant;
            RegisterDate = register;
            ScheduleProfileId = scheduleProfileId;
        }
    }
}
