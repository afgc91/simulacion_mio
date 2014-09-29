using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulacionSistemaTransporteMasivoMIO.Almacenamiento;

namespace SimulacionSistemaTransporteMasivoMIO
{
    class Program
    {
        static void Main(string[] args)
        {
            CargadoraInformación c = new CargadoraInformación("");//Dependiendo del parámetro se le da un trato diferente a la lista
            List<String> list1 = c.CargarArchivo("ARCS.txt");
            List<String> list2 = c.CargarArchivo("CALENDAR.txt");
            List<String> list3 = c.CargarArchivo("DATAPLAN.txt");
            List<String> list4 = c.CargarArchivo("LINES.txt");
            List<String> list5 = c.CargarArchivo("LINESARCS.txt");
            List<String> list6 = c.CargarArchivo("LINESTOPS.txt");
            List<String> list7 = c.CargarArchivo("PLANVERSIONS.txt");
            List<String> list8 = c.CargarArchivo("SCHEDULEPROFILES.txt");
            List<String> list9 = c.CargarArchivo("SCHEDULETYPES.txt");
            List<String> list10 = c.CargarArchivo("STOPS.txt");
            List<String> list11 = c.CargarArchivo("TASKS.txt");
            List<String> list12 = c.CargarArchivo("TRIPS.txt");
            List<String> list13 = c.CargarArchivo("TRIPTYPES.txt");
            //foreach (var s in list) {
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine("Termina");
            Console.Read();
        }
    }
}
