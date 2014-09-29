using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.Almacenamiento
{
    public class ScheduleProfile
    {
        public int ScheduleProfileId;
        public String ShortName;
        public String Description;
        public int PlanVersionId;
        public DateTime RegisterDate;

        public ScheduleProfile(int id, String shortName, String desc, int planVersionId, DateTime register) {
            ScheduleProfileId = id;
            ShortName = shortName;
            Description = desc;
            PlanVersionId = planVersionId;
            RegisterDate = register;
        }
    }
}
