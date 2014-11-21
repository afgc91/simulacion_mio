using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimulacionSistemaTransporteMasivoMIO.TAD_s;
using System.Collections.Generic;



namespace UnitTestProject1
{
    [TestClass]
    public class GrafoMatrizTests
    {
        private GrafoMatriz<int> grafo;

        private void Escenario()
        {
             
            grafo = new GrafoMatriz<int>();

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
            Console.WriteLine("Prueba escenario 2");
            grafo = new GrafoMatriz<int>();
            grafo.AgregarVertice(1);
            grafo.AgregarVertice(2);
            grafo.AgregarVertice(3);
            grafo.AgregarArista(0, 2, 2.0);
            grafo.AgregarArista(0, 1, 3.0);

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
        private void EscenarioDijkstra()
        {
            grafo = new GrafoMatriz<int>();
            grafo.AgregarVertice(1);
            grafo.AgregarVertice(2);
            grafo.AgregarVertice(3);
            grafo.AgregarVertice(4);
            grafo.AgregarVertice(5);
            grafo.AgregarVertice(6);
            grafo.AgregarVertice(7);
            grafo.AgregarVertice(8);
            grafo.AgregarVertice(9);
            grafo.AgregarVertice(10);
            grafo.AgregarVertice(11);
            grafo.AgregarVertice(12);
            grafo.AgregarVertice(13);
            grafo.AgregarArista(0, 1, 2.0);
            grafo.AgregarArista(1, 0, 2.0);
            grafo.AgregarArista(1, 2, 1.0);
            grafo.AgregarArista(2, 1, 1.0);
            grafo.AgregarArista(2, 3, 1.0);
            grafo.AgregarArista(3, 2, 1.0);
            grafo.AgregarArista(3, 4, 2.0);
            grafo.AgregarArista(4, 3, 2.0);
            grafo.AgregarArista(2, 5, 2.0);
            grafo.AgregarArista(5, 2, 2.0);
            grafo.AgregarArista(5, 6, 2.0);
            grafo.AgregarArista(6, 5, 2.0);
            grafo.AgregarArista(6, 7, 2.0);
            grafo.AgregarArista(7, 6, 2.0);
            grafo.AgregarArista(7, 8, 1.0);
            grafo.AgregarArista(8, 9, 1.0);
            grafo.AgregarArista(7, 11, 1.0);
            grafo.AgregarArista(11, 7, 1.0);
            grafo.AgregarArista(7, 10, 1.0);
            grafo.AgregarArista(10, 7, 1.0);
            grafo.AgregarArista(9, 10, 1.0);
            grafo.AgregarArista(10, 9, 1.0);
            grafo.AgregarArista(11, 12, 1.0);
            grafo.AgregarArista(12, 11, 1.0);

        }
        private void EscenarioMuchosVertices()
        {
            grafo = new GrafoMatriz<int>();
            for (int i = 0; i < 1001; i++)
            {
                grafo.AgregarVertice(i);
            }
            for (int i = 0; i < 1000; i++)
            {
                grafo.AgregarArista(i, i + 1, 5);
            }
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
            grafo.AgregarArista(0, 2, 2.0);
            grafo.AgregarArista(0, 1, 3.0);
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
            EscenarioDijkstra();
            List<int> a = grafo.BFS(2);
            int esp1 = 2;
            int esp2 = 1;
            int esp3 = 3;
            //Assert.AreEqual(esp1, a[0]);
            //Assert.AreEqual(esp2, a[1]);
            //Assert.AreEqual(esp3, a[2]);
            Assert.AreEqual(13, a.Count);

        }
        
        public void TestDarCamino()
        {
            Escenario3();
            List<int> a = grafo.DarCamino(2, 3);
            int esp1 = 2;
            int esp2 = 1;
            int esp3 = 3;
            int act1 = a[0];
            int act2 = a[1];
            int act3 = a[2];
            Assert.AreEqual(esp1, act1);
            Assert.AreEqual(esp2, act2);
            Assert.AreEqual(esp3, act3);

        }
        [TestMethod]
        public void TestDijkstra()
        {
            EscenarioDijkstra();
            object[] resultado = grafo.Dijkstra(1);
            double[] pesos = (double[])resultado[0];
            List<int> vertices = (List<int>)resultado[1];
            double act1 = pesos[0];
            double act2 = pesos[1];
            double act3 = pesos[2];
            double act4 = pesos[3];
            double act5 = pesos[4];
            double act6 = pesos[5];
            double act7 = pesos[6];
            double act8 = pesos[7];
            double act9 = pesos[8];
            double act10 = pesos[9];
            double act11 = pesos[10];
            double act12 = pesos[11];
            double act13 = pesos[12];
            double esp1 = 0;
            double esp2 = 2;
            double esp3 = 3;
            double esp4 = 4.0;
            double esp5 = 6.0;
            double esp6 = 5.0;
            double esp7 = 7.0;
            double esp8 = 9.0;
            double esp9 = 10.0;
            double esp10 = 11.0;
            double esp11 = 10.0;
            double esp12 = 10.0;
            double esp13 = 11.0;
            Assert.AreEqual(esp1, act1);
            Assert.AreEqual(esp2, act2);
            Assert.AreEqual(esp3, act3);
            Assert.AreEqual(esp4, act4);
            Assert.AreEqual(esp5, act5);
            Assert.AreEqual(esp6, act6);
            Assert.AreEqual(esp7, act7);
            Assert.AreEqual(esp8, act8);
            Assert.AreEqual(esp9, act9);
            Assert.AreEqual(esp10, act10);
            Assert.AreEqual(esp11, act11);
            Assert.AreEqual(esp12, act12);
            Assert.AreEqual(esp13, act13);
           



        }
        [TestMethod]
        public void TestMuchosVertices()
        {
            EscenarioMuchosVertices();
            grafo.BFS(1);

        }
    }
}
