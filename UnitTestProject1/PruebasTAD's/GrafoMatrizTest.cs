using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimulacionSistemaTransporteMasivoMIO.TAD_s;
using System.Collections.Generic;


namespace UnitTestProject1
{
    [TestClass]
    public class GrafoMatrizTests
    {
        private GrafoMatriz<Int32> grafo;
        private void Escenario()
        {
             
            grafo = new GrafoMatriz<Int32>();

        }
        private void Escenario1()
        {
            grafo = new GrafoMatriz<int>();
            grafo.AgregarVertice(1);
            grafo.AgregarVertice(2);
            grafo.AgregarVertice(3);
        }
        private void Escenario2()
        {
            grafo = new GrafoMatriz<int>();
            grafo.AgregarVertice(1);
            grafo.AgregarVertice(2);
            grafo.AgregarVertice(3);
            grafo.AgregarArista(1, 3, 2.0);
            grafo.AgregarArista(1, 2, 3.0);

        }
        private void Escenario3()
        {
            grafo = new GrafoMatriz<int>();
            grafo.AgregarVertice(1);
            grafo.AgregarVertice(2);
            grafo.AgregarVertice(3);
            grafo.AgregarArista(1, 3, 2.0);
            grafo.AgregarArista(1, 2, 3.0);
            grafo.AgregarArista(2, 1, 1.0);

        }
        [TestMethod]
        public void TestAgregarVertice()
        {
            Escenario();
            grafo.AgregarVertice(5);
            int esp = 1;
            int act = grafo.CantidadVertices();

            Assert.AreEqual(esp, act);

        }
       [TestMethod]
        public void TestAgregarArista()
        {
            Escenario1();
            grafo.AgregarArista(1, 3, 2.0);
            grafo.AgregarArista(1, 2, 3.0);
            int esp = 2;
            int act = grafo.CantidadAristas();
            Assert.AreEqual(esp, act);
        }
      [TestMethod]
       public void TestEliminarVertice()
       {
           Escenario1();
           grafo.EliminarVertice(1);
           int esp = 2;
           int act = grafo.CantidadVertices();
           Assert.AreEqual(esp, act);
       }
    [TestMethod]
      public void TestEliminarArista()
      {
          Escenario2();
          grafo.ElinimarArista(1, 2, 3.0);
          int esp = 1;
          int act = grafo.CantidadAristas();
          Assert.AreEqual(esp, act);
      }
        [TestMethod]
    public void TestDarAdyacencias() {
        Escenario2();
        List<Int32> a = grafo.DarAdyacencias(1);
        List<Int32> b = grafo.DarAdyacencias(2);
        List<Int32> c = grafo.DarAdyacencias(3);
        int esp1 = 2;
        int act1 = a.Count;
        int esp2 = 0;
        int act2 = b.Count;
        int esp3 = 0;
        int act3 = c.Count;
        Assert.AreEqual(esp1, act1);
        Assert.AreEqual(esp2, act2);
        Assert.AreEqual(esp3, act3);
        }
        [TestMethod]
        public void TestHayCamino()
        {
            Escenario3();
            bool act = grafo.HayCamino(2, 3);
            bool esp = true;
            bool act1 = grafo.HayCamino(3, 2);
            bool esp1 = false;

            Assert.AreEqual(esp, act);
            Assert.AreEqual(esp1, act1);

        }
        [TestMethod]
        public void TestBFS()
        {
            Escenario3();
            List<int> a = grafo.BFS(2);
            int esp1 = 2;
            int esp2 = 1;
            int esp3 = 3;
            Assert.AreEqual(esp1, a[0]);
            Assert.AreEqual(esp2, a[1]);
            Assert.AreEqual(esp3, a[2]);

        }

    }
}
