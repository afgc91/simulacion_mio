using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.Almacenamiento
{
    public class Stop
    {
        public int StopId;
        public int PlanVersionId;
        public String ShortName;
        public String LongName;
        public double GpsX;
        public double GpsY;
        public double DecimalLongitude;
        public double DecimalLatitude;

        public Stop(int id, int planVersionId, String shortName, String longName, int x, int y, double longitude, double latitude) {
            StopId = id;
            PlanVersionId = planVersionId;
            LongName = longName;
            ShortName = shortName;
            GpsX = x;
            GpsY = y;
            DecimalLongitude = longitude;
            DecimalLatitude = latitude;
        }

        public override string ToString()
        {
            return StopId + LongName + "";
        }

    }
}
