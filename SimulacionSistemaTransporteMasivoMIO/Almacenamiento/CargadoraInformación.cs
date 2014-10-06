using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimulacionSistemaTransporteMasivoMIO.Almacenamiento
{
    public class CargadoraInformación
    {
        public List<Arc> ARCS;
        public List<CalendarMIO> CALENDAR;
        public List<DataPlan> DATAPLAN;
        public List<Line> LINES;
        public List<LineArc> LINESARCS;
        public List<LineStop> LINESTOPS;
        public List<PlanVersion> PLANVERSIONS;
        public List<ScheduleProfile> SCHEDULEPROFILES;
        public List<ScheduleType> SCHEDULETYPES;
        public List<Stop> STOPS;
        public List<TaskMIO> TASKS;
        public List<Trip> TRIPS;
        public List<TripType> TRIPTYPES;

        /// <summary>
        /// Instancias cuyo archivo será cargado.
        /// 1. ARCS
        /// 2. CALENDAR
        /// 3. DATAPLAN
        /// 4. LINES
        /// 5. LINESARCS
        /// 6. LINESTOPS
        /// 7. PLANVERSIONS
        /// 8. SCHEDULEPROFILES
        /// 9. SCHEDULETYPES
        /// 10. STOPS
        /// 11. TASKS
        /// 12. TRIPS
        /// 13. TRIPTYPES
        /// </summary>
        public String Instance;

        public CargadoraInformación() {
            //Instance = ins;
            ARCS = new List<Arc>();
            CALENDAR = new List<CalendarMIO>();
            DATAPLAN = new List<DataPlan>();
            LINES = new List<Line>();
            LINESARCS = new List<LineArc>();
            LINESTOPS = new List<LineStop>();
            PLANVERSIONS = new List<PlanVersion>();
            SCHEDULEPROFILES = new List<ScheduleProfile>();
            SCHEDULETYPES = new List<ScheduleType>();
            STOPS = new List<Stop>();
            TASKS = new List<TaskMIO>();
            TRIPS = new List<Trip>();
            TRIPTYPES = new List<TripType>();
            //AlmacenarInformacion(CargarArchivo());
        }

        /// <summary>
        /// Carga la información del archivo ingresado por parámetro que se encuentra en la ruta C:\Users\Public\Base de datos MIO\ y los devuelve en una lista.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private List<String> CargarArchivo() {
            //FileInfo file = (from f in new DirectoryInfo(@"C:\").GetFiles()
            //           where f.Name.Equals(fileName)
            //           select f).First();

            List<String> list = new List<String>();
            StreamReader reader = new StreamReader(@"C:\Users\1151959323\Base de datos MIO\" + Instance);
            String line = "";
            int cont = 0;
            while (true) {
                line = reader.ReadLine();
                //Console.WriteLine(line);
                cont += 1;
                if (line==null)
                {
                    //Console.WriteLine("No hay más líneas");
                    break;
                }
                list.Add(line);
            }
            //Console.WriteLine("Cantidad líneas: " + cont);
            return list; 
        }

        /// <summary>
        /// Guarda la información obtenida de los archivos planos en listas locales.
        /// </summary>
        /// <param name="list"></param>
        private void AlmacenarInformacion(List<String> list) {
            if (Instance.Equals("SCHEDULETYPES.txt")) {
                int cont = 1;
                ScheduleType st = null;
                String[] atributes = null;
                for (; cont<(list.Count); cont++) {
                    atributes = list.ElementAt(cont).Split('\t');
                    int id = Int32.Parse(atributes[0]);
                    int planVersionId = Int32.Parse(atributes[1]);
                    st = new ScheduleType(id, planVersionId, atributes[2], atributes[3]);
                    SCHEDULETYPES.Add(st);
                }
                Console.WriteLine("Cantidad ScheduleTypes: " + SCHEDULETYPES.Count);
            }
            else if (Instance.Equals("TRIPTYPES.txt")) {
                int cont = 1;
                TripType tt = null;
                String[] atributes = null;
                for (; cont < (list.Count); cont++)
                {
                    atributes = list.ElementAt(cont).Split('\t');
                    int id = Int32.Parse(atributes[0]);
                    tt = new TripType(id, atributes[1]);
                    TRIPTYPES.Add(tt);
                }
                Console.WriteLine("Cantidad TripTypes: " + TRIPTYPES.Count);
            }else if(Instance.Equals("DATAPLAN.txt")){
                int cont = 1;
                DataPlan dp = null;
                String[] atributes;
                for (; cont < (list.Count); cont++) {
                    atributes = list.ElementAt(cont).Split('\t');
                    //Console.WriteLine(atributes.Length);
                    int id = Int32.Parse(atributes[0]);
                    String lineShortName = atributes[1];
                    int lineId = Int32.Parse(atributes[2]);
                    int orientation = Int32.Parse(atributes[3]);
                    int totalStops = Int32.Parse(atributes[4]);
                    int tripLenght = Int32.Parse(atributes[5]);
                    int taskId = Int32.Parse(atributes[6]);
                    int tripId = Int32.Parse(atributes[7]);
                    int tripStartTime = Int32.Parse(atributes[8]);
                    int scheduleTypeId = Int32.Parse(atributes[9]);
                    int tripTypeId = Int32.Parse(atributes[10]);
                    int planVersionId = Int32.Parse(atributes[11]);
                    String contratist = atributes[12];
                    DateTime register = Convert.ToDateTime(atributes[13]);
                    //Console.WriteLine(atributes[14]);
                    int tripEndTime = atributes[14].Contains("null")?-1:Int32.Parse(atributes[14]);
                    int tripTransitTime = atributes[15].Contains("null") ? -1 : Int32.Parse(atributes[15]);
                    dp = new DataPlan(id, lineShortName, lineId, orientation, totalStops, tripLenght, taskId, tripId, tripStartTime, scheduleTypeId, tripTypeId, planVersionId, contratist, register, tripEndTime, tripTransitTime);
                    //if (cont == 40) { break; }
                    DATAPLAN.Add(dp);
                }
                Console.WriteLine("Cantidad registros DataPlan: " + DATAPLAN.Count);
            }else if(Instance.Equals("ARCS.txt")){
                int cont = 1;
                Arc a = null;
                String[] atributes;
                for (; cont < (list.Count); cont++) {
                    atributes = list.ElementAt(cont).Split('\t');
                    int id = Int32.Parse(atributes[0]);
                    int planVersionId = Int32.Parse(atributes[1]);
                    int start = Int32.Parse(atributes[2]);
                    int end = Int32.Parse(atributes[3]);
                    String startPoint = atributes[4];
                    String endPoint = atributes[5];
                    String desc = atributes[6];
                    int lenght = Int32.Parse(atributes[7]);
                    a = new Arc(id, planVersionId, start, end, startPoint, endPoint, desc, lenght);
                    ARCS.Add(a);
                }
                Console.WriteLine("Cantidad Arcs: " + ARCS.Count);
            }
            else if (Instance.Equals("CALENDAR.txt"))
            {
                int cont = 1;
                CalendarMIO c = null;
                String[] atributes = null;
                for (; cont < (list.Count); cont++)
                {
                    atributes = list.ElementAt(cont).Split('\t');
                    int id = Int32.Parse(atributes[0]);
                    DateTime date = Convert.ToDateTime(atributes[1]);
                    int scheduleTypeId = Int32.Parse(atributes[2]);
                    int planVersionId = Int32.Parse(atributes[3]);
                    c = new CalendarMIO(id, date, scheduleTypeId, planVersionId);
                    CALENDAR.Add(c);
                }
                Console.WriteLine("Cantidad registros Calendar: " + CALENDAR.Count);
            }
            else if (Instance.Equals("LINES.txt"))
            {
                int cont = 1;
                Line l = null;
                String[] atributes = null;
                for (; cont < (list.Count); cont++)
                {
                    atributes = list.ElementAt(cont).Split('\t');
                    int id = Int32.Parse(atributes[0]);
                    int planVersionId = Int32.Parse(atributes[1]);
                    String shortName = atributes[2];
                    String desc = atributes[3];
                    l = new Line(id, planVersionId, shortName, desc);
                    LINES.Add(l);
                }
                Console.WriteLine("Cantidad Lines: " + LINES.Count);
            }
            else if (Instance.Equals("LINESARCS.txt"))
            {
                int cont = 1;
                LineArc la = null;
                String[] atributes = null;
                for (; cont < (list.Count); cont++)
                {
                    atributes = list.ElementAt(cont).Split('\t');
                    int id = Int32.Parse(atributes[0]);
                    int lineId = Int32.Parse(atributes[1]);
                    int arcId = Int32.Parse(atributes[2]);
                    int arcSequence = Int32.Parse(atributes[3]);
                    int orientation = Int32.Parse(atributes[4]);
                    int planVersionId = Int32.Parse(atributes[5]);
                    Int16 lineVariant = Int16.Parse(atributes[6]);
                    DateTime register = Convert.ToDateTime(atributes[7]);
                    la = new LineArc(id, lineId, arcId, arcSequence, orientation, planVersionId, lineVariant, register);
                    LINESARCS.Add(la);
                }
                Console.WriteLine("Cantidad LinesArcs: " + LINESARCS.Count);
            }
            else if (Instance.Equals("LINESTOPS.txt"))
            {
                int cont = 1;
                LineStop ls = null;
                String[] atributes = null;
                for (; cont < (list.Count); cont++)
                {
                    //int id, int stopSeq, Int16 orientation, int lineId, int stopId, int planVersionId, int lineVariant, DateTime register, int lineVariantType
                    atributes = list.ElementAt(cont).Split('\t');
                    int id = Int32.Parse(atributes[0]);
                    int stopSeq = Int32.Parse(atributes[1]);
                    Int16 orientation = Int16.Parse(atributes[2]);
                    int lineId = Int32.Parse(atributes[3]);
                    int stopId = Int32.Parse(atributes[4]);
                    int planVersionId = Int32.Parse(atributes[5]);
                    int lineVariant = Int32.Parse(atributes[6]);
                    DateTime register = Convert.ToDateTime(atributes[7]);
                    int lineVariantType = Int32.Parse(atributes[8]);
                    ls = new LineStop(id, stopSeq, orientation, lineId, stopId, planVersionId, lineVariant, register, lineVariantType);
                    LINESTOPS.Add(ls);
                }
                Console.WriteLine("Cantidad LineStops: " + LINESTOPS.Count);
            }
            else if (Instance.Equals("PLANVERSIONS.txt"))
            {
                int cont = 1;
                PlanVersion pv = null;
                String[] atributes = null;
                for (; cont < (list.Count); cont++)
                {
                    //int planVersionId, DateTime activationDate, TimeSpan creationDate
                    atributes = list.ElementAt(cont).Split('\t');
                    int id = Int32.Parse(atributes[0]);
                    DateTime activationDate = Convert.ToDateTime(atributes[1]);
                    DateTime creationDate = Convert.ToDateTime(atributes[2]);
                    pv = new PlanVersion(id, activationDate, creationDate);
                    PLANVERSIONS.Add(pv);
                }
                Console.WriteLine("Cantidad PlanVersions: " + PLANVERSIONS.Count);
            }
            else if (Instance.Equals("SCHEDULEPROFILES.txt"))
            {
                int cont = 1;
                ScheduleProfile sp = null;
                String[] atributes = null;
                for (; cont < (list.Count); cont++)
                {
                    //int id, String shortName, String desc, int planVersionId, DateTime register
                    atributes = list.ElementAt(cont).Split('\t');
                    int id = Int32.Parse(atributes[0]);
                    String shortName = atributes[1];
                    String desc = atributes[2];
                    int planVersionId = Int32.Parse(atributes[3]);
                    DateTime register = Convert.ToDateTime(atributes[4]);
                    sp = new ScheduleProfile(id, shortName, desc, planVersionId, register);
                    SCHEDULEPROFILES.Add(sp);
                }
                Console.WriteLine("Cantidad ScheduleProfiles: " + SCHEDULEPROFILES.Count);
            }
            else if (Instance.Equals("STOPS.txt"))
            {
                int cont = 1;
                Stop s = null;
                String[] atributes = null;
                for (; cont < (list.Count); cont++)
                {
                    //int id, int planVersionId, String shortName, String longName, int x, int y, double longitude, double latitude
                    atributes = list.ElementAt(cont).Split('\t');
                    int id = Int32.Parse(atributes[0]);
                    int planVersionId = Int32.Parse(atributes[1]);
                    String shortName = atributes[2];
                    String longName = atributes[3];
                    int x = Int32.Parse(atributes[4]);
                    int y = Int32.Parse(atributes[5]);
             
                    double longitude = Convert.ToDouble(atributes[6], new System.Globalization.CultureInfo("en-US"));

                    double latitude = Convert.ToDouble(atributes[7], new System.Globalization.CultureInfo("en-US"));
                    s = new Stop(id, planVersionId, shortName, longName, x, y, longitude, latitude);
                    STOPS.Add(s);
                }
                Console.WriteLine("Cantidad Stops: " + STOPS.Count);
            }
            else if (Instance.Equals("TASKS.txt"))
            {
                int cont = 1;
                TaskMIO t = null;
                String[] atributes = null;
                for (; cont < (list.Count); cont++)
                {
                    //int id, int scheduleTypeId, int lineId, int planVersionId
                    atributes = list.ElementAt(cont).Split('\t');
                    int id = Int32.Parse(atributes[0]);
                    int scheduleTypeId = Int32.Parse(atributes[1]);
                    int lineId = Int32.Parse(atributes[2]);
                    int planVersionId = Int32.Parse(atributes[3]);
                    t = new TaskMIO(id, scheduleTypeId, lineId, planVersionId);
                    TASKS.Add(t);
                }
                Console.WriteLine("Cantidad Tasks: " + TASKS.Count);
            }
            else if (Instance.Equals("TRIPS.txt"))
            {
                int cont = 1;
                Trip t = null;
                String[] atributes = null;
                for (; cont < (list.Count); cont++)
                {
                    //int id, int tripId, int planVersionId, int tripTypeId, int scheduleTypeId, int tripSeq, String startTime, int taskId, int lineId, int startStopId, int endStopId, String desc, int orientation, int lineVariant, DateTime register, int scheduleProfileId
                    atributes = list.ElementAt(cont).Split('\t');
                    int id = Int32.Parse(atributes[0]);
                    int tripId = Int32.Parse(atributes[1]);
                    int planVersionId = Int32.Parse(atributes[2]);
                    int tripTypeId = Int32.Parse(atributes[3]);
                    int scheduleTypeId = Int32.Parse(atributes[4]);
                    int tripSeq = Int32.Parse(atributes[5]);
                    String startTime = atributes[6];
                    int taskId = Int32.Parse(atributes[7]);
                    int lineId = Int32.Parse(atributes[8]);
                    int startStopId = Int32.Parse(atributes[9]);
                    int endStopId = Int32.Parse(atributes[10]);
                    String desc = atributes[11];
                    int orientation = Int32.Parse(atributes[12]);
                    int lineVariant = Int32.Parse(atributes[13]);
                    DateTime register = Convert.ToDateTime(atributes[14]);
                    int scheduleProfileId = Int32.Parse(atributes[15]);
                    t = new Trip(id, tripId, planVersionId, tripTypeId, scheduleTypeId, tripSeq, startTime, taskId, lineId, startStopId, endStopId, desc, orientation, lineVariant, register, scheduleProfileId);
                    TRIPS.Add(t);
                }
                Console.WriteLine("Cantidad Trips: " + TRIPS.Count);
            }
        }

        public void AlmacenarInformacion(String ins) {
            SetInstance(ins);
            AlmacenarInformacion(CargarArchivo());
        }

        private void SetInstance(String ins) {
            Instance = ins;
        }

    }
}
