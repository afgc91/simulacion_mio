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
        private CargadoraInformación carga;
        private GrafoMatriz<Stop> matriz;

        private void Escenario1(){
            carga = new CargadoraInformación();
            matriz = new GrafoMatriz<Stop>();
            for (int i = 0; i < carga.STOPS.Count; i++)
            {
                matriz.AgregarVertice(carga.STOPS[i]);
            }
            for (int i = 0; i < carga.ARCS.Count; i++)
            {
                Stop inicio = null;
                Stop fin = null;
                for (int j = 0; j < carga.STOPS.Count; j++)
                {
                    if (carga.ARCS[i].StopIdStart.Equals(carga.STOPS[i].StopId))
                    {
                        inicio = carga.STOPS[i];
                    }
                    if (carga.STOPS[i].StopId.Equals(carga.ARCS[i].StopIdEnd))
                    {
                        fin = carga.STOPS[i];
                    }
                }
                if (inicio != null && fin != null)
                {
                    matriz.AgregarArista(inicio, fin, carga.ARCS[i].ArcLenght);
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
            List<Stop> cant = matriz.BFS(carga.STOPS[1]);
            int esp = 1000;
            int act = cant.Count;
            Assert.AreEqual(esp, act);

        }
    }
}
