using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionSistemaTransporteMasivoMIO.TAD_s.ArregloColas
{
    public class ArregloCola<E> : IArregloCola<E>
    {
        private int tamano;
        private Queue<E>[] colas;

        public ArregloCola(int tamano)
        {
            this.tamano = tamano;
            colas = new Queue<E>[this.tamano];

            for (int i = 0; i < tamano; i++)
            {
                colas[i] = new Queue<E>();
            }

        }

        public void AgregarElemento(E elemento, int pos)
        {
            colas[pos].Enqueue(elemento);
        }

        public void EliminarElemento(int pos)
        {
            colas[pos].Dequeue();
        }

        public bool ColaVacia(int pos)
        {
            return (colas[pos].Count == 0) ? true : false;
        }

        public int TamanoCola(int pos)
        {
            return colas[pos].Count;
        }

        public E ObtenerElemento(int pos)
        {
            return colas[pos].Peek();
        }

        public int DarTamano()
        {
            return tamano;
        }
    }
}
