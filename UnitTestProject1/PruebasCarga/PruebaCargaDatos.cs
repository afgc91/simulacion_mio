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
        private CargadoraInformacion c;
        private GrafoMatriz<Stop> matriz;

        private void Escenario1(){
            c = new CargadoraInformacion(@"..\\..\\..\\SimulacionSistemaTransporteMasivoMio\Almacenamiento\Base de datos\");
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
                try
                {
                    matriz.AgregarVertice(c.STOPS[i]);
                }
                catch (Exception)
                {

                }
            }
            for (int i = 0; i < c.ARCS.Count; i++)
            {
                int inicio = -1;
                int fin = -1;
                for (int j = 0; j < c.STOPS.Count; j++)
                {
                    if (c.ARCS[i].StopIdStart == c.STOPS[j].StopId)
                    {
                        inicio = j;
                    }
                    if (c.STOPS[j].StopId == c.ARCS[i].StopIdEnd)
                    {
                        fin = j;
                    }
                }
                
                    //try
                    //{
                        matriz.AgregarArista(inicio, fin, c.ARCS[i].ArcLenght);
                    //}
                    //catch (Exception)
                    //{

                    //}
               
              
            }

        }
        private void Escenario2()
        {
          
        }
        [TestMethod]
        public void TestCargaCompletaVertices()
        {
            Escenario1();
            int esp = 1867;
            int act = matriz.CantidadVertices();
            Assert.AreEqual(esp, act);
            
        }
        [TestMethod]
        public void TestCargaCompletaAristas()
        {
            Escenario1();
            int esp = 16399;
            int act = matriz.CantidadAristas();
            Assert.AreEqual(esp, act);
        }
        [TestMethod]
        public void TestConexión()
        {
            Escenario1();
            
            List<Stop> cant = matriz.BFS(c.STOPS[500]);
            int esp = 1867;
            int act = cant.Count;
            Assert.AreEqual(esp, act);

        }
    }
}
