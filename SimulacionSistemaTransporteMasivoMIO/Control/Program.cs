﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulacionSistemaTransporteMasivoMIO.Almacenamiento;
using SimulacionSistemaTransporteMasivoMIO.Vista;

namespace SimulacionSistemaTransporteMasivoMIO
{
    class Program
    {
        static void Main(string[] args)
        {
          
            CargadoraInformacion c = new CargadoraInformacion(@"..\\..\\Almacenamiento\Base de datos\");
            c.AlmacenarInformacion("TRIPTYPES.txt");
            c.AlmacenarInformacion("SCHEDULETYPES.txt");
            c.AlmacenarInformacion("DATAPLAN.txt");
            c.AlmacenarInformacion("ARCS.txt");
            c.AlmacenarInformacion("CALENDAR.txt");
            c.AlmacenarInformacion("LINES.txt");
            c.AlmacenarInformacion("LINESARCS.txt");
            c.AlmacenarInformacion("LINESTOPS.txt");
            c.AlmacenarInformacion("PLANVERSIONS.txt");
            c.AlmacenarInformacion("SCHEDULEPROFILES.txt");
            c.AlmacenarInformacion("STOPS.txt");
            c.AlmacenarInformacion("TASKS.txt");
            c.AlmacenarInformacion("TRIPS.txt");
            //VentanaMIO ventanaMIO = new VentanaMIO(c);
            FormInicio ventanaMIO = new FormInicio(c);
            ventanaMIO.ShowDialog();
        }
    }
}
