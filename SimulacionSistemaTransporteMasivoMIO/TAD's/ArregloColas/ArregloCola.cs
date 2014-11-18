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

           

        }
        public void inicializarCola(int id){
            colas[id] = new Queue<E>();
        }
        public bool colaEnUso(int id)
        {
          return (colas[id] == null) ? false:true;
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
