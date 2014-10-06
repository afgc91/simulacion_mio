using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimulacionSistemaTransporteMasivoMIO.TAD_s;
using System.Collections.Generic;
using SimulacionSistemaTransporteMasivoMIO.Almacenamiento;

namespace UnitTestProject1.PruebasCarga
{
    [TestClass]
    public class PruebaCargaDatos
    {
        private CargadoraInformación c;
        private GrafoMatriz<Stop> matriz;

        private void Escenario1(){
            c = new CargadoraInformación();
            matriz = new GrafoMatriz<Stop>();
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

            for (int i = 0; i < c.STOPS.Count; i++)
            {
                matriz.AgregarVertice(c.STOPS[i]);
            }
            for (int i = 0; i < c.ARCS.Count; i++)
            {
                Stop inicio = null;
                Stop fin = null;
                for (int j = 0; j < c.STOPS.Count; j++)
                {
                    if (c.ARCS[i].StopIdStart == c.STOPS[j].StopId)
                    {
                        inicio = c.STOPS[j];
                    }
                    if (c.STOPS[j].StopId == c.ARCS[i].StopIdEnd)
                    {
                        fin = c.STOPS[j];
                    }
                }
                if (inicio != null && fin != null)
                {
                    
                        matriz.AgregarArista(inicio, fin, c.ARCS[i].ArcLenght);

                }
                else
                {
                   
                }
              
            }

        }
        [TestMethod]
        public void TestCargaCompletaVertices()
        {
            Escenario1();
            int esp = 1000;
            int act = matriz.CantidadVertices();
            Assert.AreEqual(esp, act);
            
        }
        [TestMethod]
        public void TestCargaCompletaAristas()
        {
            Escenario1();
            int esp = 1000;
            int act = matriz.CantidadAristas();
            Assert.AreEqual(esp, act);
        }
        [TestMethod]
        public void TestConexión()
        {
            Escenario1();
            List<Stop> cant = matriz.BFS(c.STOPS[500]);
            int esp = 1000;
            int act = cant.Count;
            Assert.AreEqual(esp, act);

        }
    }
}
