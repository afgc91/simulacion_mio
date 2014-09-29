using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimulacionSistemaTransporteMasivoMIO.TAD_s.ArregloColas;
using System.Collections.Generic;


namespace UnitTestProject1.PruebasTAD_s
{
    [TestClass]
    public class ArregloColasTest
    {

        ArregloCola<int> arreglo;

        private void Escenario()
        {
            arreglo = new ArregloCola<int>(5);
        }
        private void Escenario1()
        {
            arreglo = new ArregloCola<int>(5);
            arreglo.AgregarElemento(3, 1);
            arreglo.AgregarElemento(2, 1);
            arreglo.AgregarElemento(2, 3);

        }
        [TestMethod]
        public void TestAgregarElemento()
        {
            Escenario();
            arreglo.AgregarElemento(3, 1);
            arreglo.AgregarElemento(2, 1);
            arreglo.AgregarElemento(2, 3);
            int esp1 = 2;
            int act1 = arreglo.TamanoCola(1);
            int esp2 = 1;
            int act2 = arreglo.TamanoCola(3);
            Assert.AreEqual(esp1, act1);
            Assert.AreEqual(esp2, act2);

        }
        [TestMethod]
        public void TestEliminarElemento()
        {
            Escenario1();
            arreglo.EliminarElemento(1);
            arreglo.EliminarElemento(3);
            int esp1 = 1;
            int esp2 = 0;
            int act1 = arreglo.TamanoCola(1);
            int act2 = arreglo.TamanoCola(3);
            Assert.AreEqual(esp1, act1);
            Assert.AreEqual(esp2, act2);

        }
        [TestMethod]
        public void TestColaVacia()
        {
            Escenario();
            bool act = arreglo.ColaVacia(0);
            bool esp = true;
            Assert.AreEqual(esp, act);
        }

        [TestMethod]
        public void TestTamanoCola()
        {
            Escenario1();
            int act = arreglo.TamanoCola(1);
            int esp = 2;
            Assert.AreEqual(act, esp);
        }
        [TestMethod]
        public void TestObtenerElemento()
        {
            Escenario1();
            int act = arreglo.ObtenerElemento(1);
            int esp = 3;
            Assert.AreEqual(esp, act);
        }
        public void TestDarTamano()
        {
            Console.WriteLine("Prueba dar tamaño");
            Escenario();
            int esp = 5;
            int act = arreglo.DarTamano();
            Assert.AreEqual(esp, act);
        }
    }
}
